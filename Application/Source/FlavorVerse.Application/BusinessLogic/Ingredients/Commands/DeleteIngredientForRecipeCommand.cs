using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Category;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FluentValidation;

namespace FlavorVerse.Application.BusinessLogic.Ingredients.Commands;

public class DeleteIngredientForRecipeCommand : ICommand
{
    public DeleteIngredientForRecipeDto DeleteIngredientDto { get; set; }

    public DeleteIngredientForRecipeCommand(DeleteIngredientForRecipeDto deleteIngredientDto) => DeleteIngredientDto = deleteIngredientDto;

    // Validators
    public class DeleteIngredientForRecipeValidtion : AbstractValidator<DeleteIngredientForRecipeDto>
    {
        public DeleteIngredientForRecipeValidtion(IUnitOfWork unitOfWork)
        {
            RuleFor(x => x.RecipeId)
               .NotEmpty()
               .WithMessage("Recipe id is required.")
               .MustAsync(unitOfWork.RecipeRepository.RecipeExistByIdAsync)
               .WithMessage("Recipe with given id doesn't exists.");

            RuleFor(x => x.IngredientId)
                .NotEmpty()
                .WithMessage("Ingredient id is required.")
                .MustAsync(unitOfWork.IngredientRepoistory.IngredientExistByIdAsync)
                .WithMessage("Ingredient with given id doesn't exists.");
        }
    }

    // Handler
    public class DeleteIngredientForRecipeHandler : BaseHandler<DeleteIngredientForRecipeDto>, ICommandHandler<DeleteIngredientForRecipeCommand>
    {
        public DeleteIngredientForRecipeHandler(ITransactionService transactionService, IUnitOfWork unitOfWork, IValidator<DeleteIngredientForRecipeDto> validator) : base(transactionService, unitOfWork, validator)
        {
        }

        public async Task<Result> Handle(DeleteIngredientForRecipeCommand request, CancellationToken cancellationToken)
        {
            var adminRole = UserContext.CurrentRoles.Find(x => x.Equals(Constants.ADMIN));

            var recipe = await UnitOfWork.RecipeRepository.GetRecipeByIdAsync(request.DeleteIngredientDto.RecipeId, cancellationToken);

            if (recipe is null)
            {
                return Result.Failure(Error<Recipe>.NotFound);
            }

            if (string.IsNullOrEmpty(adminRole) && recipe.UserId != UserContext.CurrentUserId)
            {
                return Result.Failure(Error.ActionForbidden);
            }

            var validationResult = await Validator.ValidateAsync(request.DeleteIngredientDto, cancellationToken);

            if (!validationResult.IsValid)
            {
                return ValidationError.FailureWithValidationResult<DeleteIngredientForRecipeDto>(validationResult);
            }

            var transactionId = Guid.NewGuid();

            return await TransactionService.TryProcess(transactionId, request.DeleteIngredientDto.RecipeId, eEntityType.RecipeIngredient, eActionType.Delete, UserContext.CurrentUserId, async () =>
            {
                var recipeIngredient = await UnitOfWork.RecipeRepository.GetRecipeIngredientByIdsAsync(request.DeleteIngredientDto.RecipeId, request.DeleteIngredientDto.IngredientId, cancellationToken) ?? throw new ArgumentException($"Recipe cuisine with given ids recipeId {request.DeleteIngredientDto.RecipeId} and ingredientId {request.DeleteIngredientDto.IngredientId} doesn't exist. Action is terminated");

                recipeIngredient.IsActive = false;
                recipeIngredient.DeletedAt = DateTime.UtcNow;
                recipeIngredient.DeletedBy = UserContext.CurrentUserId;

                if (await UnitOfWork.Complete())
                {
                    return Result.Success("Successfully deleted ingredient.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}