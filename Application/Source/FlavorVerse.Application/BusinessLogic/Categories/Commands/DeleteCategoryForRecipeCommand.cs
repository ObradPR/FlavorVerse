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

namespace FlavorVerse.Application.BusinessLogic.Categories.Commands;

public class DeleteCategoryForRecipeCommand : ICommand
{
    public DeleteCategoryForRecipeDto DeleteCategoryDto { get; set; }

    public DeleteCategoryForRecipeCommand(DeleteCategoryForRecipeDto deleteCategoryDto) => DeleteCategoryDto = deleteCategoryDto;

    // Validators
    public class DeleteCategoryForRecipeValidtion : AbstractValidator<DeleteCategoryForRecipeDto>
    {
        public DeleteCategoryForRecipeValidtion(IUnitOfWork unitOfWork)
        {
            RuleFor(x => x.RecipeId)
               .NotEmpty()
               .WithMessage("Recipe id is required.")
               .MustAsync(unitOfWork.RecipeRepository.RecipeExistByIdAsync)
               .WithMessage("Recipe with given id doesn't exists.");

            RuleFor(x => x.CategoryId)
                .NotEmpty()
                .WithMessage("Category id is required.")
                .MustAsync(unitOfWork.CategoryRepository.CategoryExistByIdAsync)
                .WithMessage("Category with given id doesn't exists.");
        }
    }

    // Handler
    public class DeleteCategoryForRecipeHandler : BaseHandler<DeleteCategoryForRecipeDto>, ICommandHandler<DeleteCategoryForRecipeCommand>
    {
        public DeleteCategoryForRecipeHandler(ITransactionService transactionService, IUnitOfWork unitOfWork, IValidator<DeleteCategoryForRecipeDto> validator) : base(transactionService, unitOfWork, validator)
        {
        }

        public async Task<Result> Handle(DeleteCategoryForRecipeCommand request, CancellationToken cancellationToken)
        {
            var adminRole = UserContext.CurrentRoles.Find(x => x.Equals(Constants.ADMIN));

            var recipe = await UnitOfWork.RecipeRepository.GetRecipeByIdAsync(request.DeleteCategoryDto.RecipeId, cancellationToken);

            if (recipe is null)
            {
                return Result.Failure(Error<Recipe>.NotFound);
            }

            if (string.IsNullOrEmpty(adminRole) && recipe.UserId != UserContext.CurrentUserId)
            {
                return Result.Failure(Error.ActionForbidden);
            }

            var validationResult = await Validator.ValidateAsync(request.DeleteCategoryDto, cancellationToken);

            if (!validationResult.IsValid)
            {
                return ValidationError.FailureWithValidationResult<DeleteCategoryForRecipeDto>(validationResult);
            }

            var transactionId = Guid.NewGuid();

            return await TransactionService.TryProcess(transactionId, request.DeleteCategoryDto.RecipeId, eEntityType.RecipeCategory, eActionType.Delete, UserContext.CurrentUserId, async () =>
            {
                var recipeCategory = await UnitOfWork.RecipeRepository.GetRecipeCategoryByIdsAsync(request.DeleteCategoryDto.RecipeId, request.DeleteCategoryDto.CategoryId, cancellationToken) ?? throw new ArgumentException($"Recipe Category with given ids recipeId {request.DeleteCategoryDto.RecipeId} and categoryId {request.DeleteCategoryDto.CategoryId} doesn't exist. Action is terminated");

                UnitOfWork.RecipeRepository.DeleteRecipeCategory(recipeCategory);

                if (await UnitOfWork.Complete())
                {
                    return Result.Success("Successfully deleted category.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}