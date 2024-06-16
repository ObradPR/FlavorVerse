using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Cuisine;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FluentValidation;

namespace FlavorVerse.Application.BusinessLogic.Cuisines.Commands;

public class DeleteCuisineForRecipeCommand : ICommand
{
    public DeleteCuisineForRecipeDto DeleteCuisineDto { get; set; }

    public DeleteCuisineForRecipeCommand(DeleteCuisineForRecipeDto deleteCuisineDto) => DeleteCuisineDto = deleteCuisineDto;

    // Validators
    public class DeleteCuisineForRecipeValidtion : AbstractValidator<DeleteCuisineForRecipeDto>
    {
        public DeleteCuisineForRecipeValidtion(IUnitOfWork unitOfWork)
        {
            RuleFor(x => x.RecipeId)
               .NotEmpty()
               .WithMessage("Recipe id is required.")
               .MustAsync(unitOfWork.RecipeRepository.RecipeExistByIdAsync)
               .WithMessage("Recipe with given id doesn't exists.");

            RuleFor(x => x.CuisineId)
                .NotEmpty()
                .WithMessage("Cuisine id is required.")
                .MustAsync(unitOfWork.CuisineRepository.CuisineExistByIdAsync)
                .WithMessage("Cuisine with given id doesn't exists.");
        }
    }

    // Handler
    public class DeleteCuisineForRecipeHandler : BaseHandler<DeleteCuisineForRecipeDto>, ICommandHandler<DeleteCuisineForRecipeCommand>
    {
        public DeleteCuisineForRecipeHandler(ITransactionService transactionService, IUnitOfWork unitOfWork, IValidator<DeleteCuisineForRecipeDto> validator) : base(transactionService, unitOfWork, validator)
        {
        }

        public async Task<Result> Handle(DeleteCuisineForRecipeCommand request, CancellationToken cancellationToken)
        {
            var adminRole = UserContext.CurrentRoles.Find(x => x.Equals(Constants.ADMIN));

            var recipe = await UnitOfWork.RecipeRepository.GetRecipeByIdAsync(request.DeleteCuisineDto.RecipeId, cancellationToken);

            if (recipe is null)
            {
                return Result.Failure(Error<Recipe>.NotFound);
            }

            if (string.IsNullOrEmpty(adminRole) && recipe.UserId != UserContext.CurrentUserId)
            {
                return Result.Failure(Error.ActionForbidden);
            }

            var validationResult = await Validator.ValidateAsync(request.DeleteCuisineDto, cancellationToken);

            if (!validationResult.IsValid)
            {
                return ValidationError.FailureWithValidationResult<DeleteCuisineForRecipeDto>(validationResult);
            }

            var transactionId = Guid.NewGuid();

            return await TransactionService.TryProcess(transactionId, request.DeleteCuisineDto.RecipeId, eEntityType.RecipeCuisine, eActionType.Delete, UserContext.CurrentUserId, async () =>
            {
                var recipeCuisine = await UnitOfWork.RecipeRepository.GetRecipeCuisineByIdsAsync(request.DeleteCuisineDto.RecipeId, request.DeleteCuisineDto.CuisineId, cancellationToken) ?? throw new ArgumentException($"Recipe cuisine with given ids recipeId {request.DeleteCuisineDto.RecipeId} and cuisineId {request.DeleteCuisineDto.CuisineId} doesn't exist. Action is terminated");

                UnitOfWork.RecipeRepository.DeleteRecipeCuisine(recipeCuisine);

                if (await UnitOfWork.Complete())
                {
                    return Result.Success("Successfully deleted cuisine.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}