using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Ingredient;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FluentValidation;

namespace FlavorVerse.Application.BusinessLogic.Ingredients.Commands;

public class EditRecipeIngredientCommand : ICommand
{
    public Guid RecipeId { get; set; }
    public int IngredientId { get; set; }
    public EditRecipeIngredientDto IngredientDto { get; set; }

    public EditRecipeIngredientCommand(Guid recipeId, int ingredientId, EditRecipeIngredientDto ingredient)
    {
        RecipeId = recipeId;
        IngredientId = ingredientId;
        IngredientDto = ingredient;
    }

    // Validators
    public class EditRecipeIngredientValidation : AbstractValidator<EditRecipeIngredientDto>
    {
        public EditRecipeIngredientValidation()
        {
            RuleFor(x => x.Quantity)
                .NotEmpty()
                .NotNull()
                .WithMessage("Quantity cannot be empty or null.")
                .MaximumLength(30)
                .WithMessage("Quantity must be at most 30 characters long.");
        }
    }

    // Handlers
    public class EditRecipeIngredientHandler : BaseHandler<EditRecipeIngredientDto>, ICommandHandler<EditRecipeIngredientCommand>
    {
        public EditRecipeIngredientHandler(ITransactionService transactionService, IUnitOfWork unitOfWork, IValidator<EditRecipeIngredientDto> validator) : base(transactionService, unitOfWork, validator)
        {
        }

        public async Task<Result> Handle(EditRecipeIngredientCommand request, CancellationToken cancellationToken)
        {
            var adminRole = UserContext.CurrentRoles.Find(x => x.Equals(Constants.ADMIN));

            var recipe = await UnitOfWork.RecipeRepository.GetRecipeByIdAsync(request.RecipeId, cancellationToken);

            if (recipe is null)
            {
                return Result.Failure(Error<Recipe>.NotFound);
            }

            if (string.IsNullOrEmpty(adminRole) && recipe.UserId != UserContext.CurrentUserId)
            {
                return Result.Failure(Error.ActionForbidden);
            }

            if (string.IsNullOrEmpty(request.IngredientDto.Quantity)
                && request.IngredientDto.IsActive is null)
            {
                return Result.Failure(Error.NullValue);
            }

            if (!string.IsNullOrEmpty(request.IngredientDto.Quantity))
            {
                var validationResult = await Validator.ValidateAsync(request.IngredientDto, cancellationToken);

                if (!validationResult.IsValid)
                {
                    return ValidationError.FailureWithValidationResult<EditRecipeIngredientDto>(validationResult);
                }
            }

            var transactionId = Guid.NewGuid();

            return await TransactionService.TryProcess(transactionId, request.RecipeId, eEntityType.RecipeIngredient, eActionType.Update, UserContext.CurrentUserId, async () =>
            {
                var recipeIngredient = recipe.RecipeIngredients.Where(x => x.IngredientId == request.IngredientId).FirstOrDefault();

                if (recipeIngredient is null)
                {
                    return (Result<string>)Result.Failure(Error<RecipeIngredient>.NotFound);
                }

                if (request.IngredientDto.IsActive == false)
                {
                    recipeIngredient.DeletedAt = DateTime.UtcNow;
                    recipeIngredient.DeletedBy = UserContext.CurrentUserId;
                    recipeIngredient.IsActive = false;
                }
                else if (request.IngredientDto.IsActive == true)
                {
                    recipeIngredient.IsActive = true;
                }

                recipeIngredient.Quantity = request.IngredientDto.Quantity ?? recipeIngredient.Quantity;
                recipeIngredient.ModifiedAt = DateTime.UtcNow;
                recipeIngredient.ModifiedBy = UserContext.CurrentUserId;

                if (await UnitOfWork.Complete())
                {
                    return Result.Success("Successfully updated recipe ingredient.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}