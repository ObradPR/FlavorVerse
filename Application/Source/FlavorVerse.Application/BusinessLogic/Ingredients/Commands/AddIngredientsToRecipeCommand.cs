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

public class AddIngredientsToRecipeCommand : ICommand
{
    public AddIngredientsToRecipeDto AddIngredientsDto { get; set; }

    public AddIngredientsToRecipeCommand(AddIngredientsToRecipeDto addIngredientsDto) => AddIngredientsDto = addIngredientsDto;

    // Validators
    public class AddIngredientsToRecipeValidtion : AbstractValidator<AddIngredientsToRecipeDto>
    {
        public AddIngredientsToRecipeValidtion(IUnitOfWork unitOfWork)
        {
            RuleFor(x => x.RecipeId)
               .NotEmpty()
               .WithMessage("Recipe id is required.")
               .MustAsync(unitOfWork.RecipeRepository.RecipeExistByIdAsync)
               .WithMessage("Recipe with given id doesn't exists.");

            RuleFor(x => x.Ingredients)
                .NotEmpty()
                .WithMessage("Ingredients are required.");
        }
    }

    // Handler
    public class AddIngredientsToRecipeHandler : BaseHandler<AddIngredientsToRecipeDto>, ICommandHandler<AddIngredientsToRecipeCommand>
    {
        public AddIngredientsToRecipeHandler(ITransactionService transactionService, IUnitOfWork unitOfWork, IValidator<AddIngredientsToRecipeDto> validator) : base(transactionService, unitOfWork, validator)
        {
        }

        public async Task<Result> Handle(AddIngredientsToRecipeCommand request, CancellationToken cancellationToken)
        {
            var adminRole = UserContext.CurrentRoles.Find(x => x.Equals(Constants.ADMIN));

            var recipe = await UnitOfWork.RecipeRepository.GetRecipeByIdAsync(request.AddIngredientsDto.RecipeId, cancellationToken);

            if (recipe is null)
            {
                return Result.Failure(Error<Recipe>.NotFound);
            }

            if (string.IsNullOrEmpty(adminRole) && recipe.UserId != UserContext.CurrentUserId)
            {
                return Result.Failure(Error.ActionForbidden);
            }

            var validationResult = await Validator.ValidateAsync(request.AddIngredientsDto, cancellationToken);

            if (!validationResult.IsValid)
            {
                return ValidationError.FailureWithValidationResult<AddIngredientsToRecipeDto>(validationResult);
            }

            var transactionId = Guid.NewGuid();

            return await TransactionService.TryProcess(transactionId, request.AddIngredientsDto.RecipeId, eEntityType.RecipeIngredient, eActionType.Insert, UserContext.CurrentUserId, async () =>
            {
                var newIngredients = new List<RecipeIngredient>();

                foreach (var item in request.AddIngredientsDto.Ingredients)
                {
                    var ingredient = await UnitOfWork.IngredientRepoistory.GetIngredientByIdAsync(item.Id, cancellationToken) ?? throw new ArgumentException($"Ingredient with given id {item.Id} doesn't exist. Action is terminated");

                    if (recipe.RecipeIngredients.FirstOrDefault(x => x.IngredientId == item.Id) is not null)
                    {
                        var oldRecipeIngredient = recipe.RecipeIngredients.FirstOrDefault(x => x.IngredientId == item.Id);

                        if (oldRecipeIngredient is not null)
                        {
                            oldRecipeIngredient.Quantity = item.Quantity;
                        }

                        continue;
                    }

                    newIngredients.Add(new RecipeIngredient
                    {
                        IngredientId = item.Id,
                        Quantity = item.Quantity,
                        RecipeId = request.AddIngredientsDto.RecipeId
                    });
                }

                if (newIngredients.Count == 0)
                {
                    return Result.Success("This recipe already contains this ingredients.");
                }

                await UnitOfWork.RecipeRepository.AddRecipeIngredientsAsync(newIngredients, cancellationToken);

                if (await UnitOfWork.Complete())
                {
                    return Result.Success("Successfully created recipe.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}