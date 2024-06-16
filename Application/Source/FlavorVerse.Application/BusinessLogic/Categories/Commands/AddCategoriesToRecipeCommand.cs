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

public class AddCategoriesToRecipeCommand : ICommand
{
    public AddCategoriesToRecipeDto AddCategoriesDto { get; set; }

    public AddCategoriesToRecipeCommand(AddCategoriesToRecipeDto addCategoriesDto) => AddCategoriesDto = addCategoriesDto;

    // Validators
    public class AddCategoriesToRecipeValidtion : AbstractValidator<AddCategoriesToRecipeDto>
    {
        public AddCategoriesToRecipeValidtion(IUnitOfWork unitOfWork)
        {
            RuleFor(x => x.RecipeId)
               .NotEmpty()
               .WithMessage("Recipe id is required.")
               .MustAsync(unitOfWork.RecipeRepository.RecipeExistByIdAsync)
               .WithMessage("Recipe with given id doesn't exists.");

            RuleFor(x => x.Categories)
                .NotEmpty()
                .WithMessage("Categories are required.");
        }
    }

    // Handler
    public class AddCategoriesToRecipeHandler : BaseHandler<AddCategoriesToRecipeDto>, ICommandHandler<AddCategoriesToRecipeCommand>
    {
        public AddCategoriesToRecipeHandler(ITransactionService transactionService, IUnitOfWork unitOfWork, IValidator<AddCategoriesToRecipeDto> validator) : base(transactionService, unitOfWork, validator)
        {
        }

        public async Task<Result> Handle(AddCategoriesToRecipeCommand request, CancellationToken cancellationToken)
        {
            var adminRole = UserContext.CurrentRoles.Find(x => x.Equals(Constants.ADMIN));

            var recipe = await UnitOfWork.RecipeRepository.GetRecipeByIdAsync(request.AddCategoriesDto.RecipeId, cancellationToken);

            if (recipe is null)
            {
                return Result.Failure(Error<Recipe>.NotFound);
            }

            if (string.IsNullOrEmpty(adminRole) && recipe.UserId != UserContext.CurrentUserId)
            {
                return Result.Failure(Error.ActionForbidden);
            }

            var validationResult = await Validator.ValidateAsync(request.AddCategoriesDto, cancellationToken);

            if (!validationResult.IsValid)
            {
                return ValidationError.FailureWithValidationResult<AddCategoriesToRecipeDto>(validationResult);
            }

            var transactionId = Guid.NewGuid();

            return await TransactionService.TryProcess(transactionId, request.AddCategoriesDto.RecipeId, eEntityType.RecipeCategory, eActionType.Insert, UserContext.CurrentUserId, async () =>
            {
                var newCategories = new List<RecipeCategory>();

                foreach (var id in request.AddCategoriesDto.Categories)
                {
                    var category = await UnitOfWork.CategoryRepository.GetCategoryByIdAsync(id, cancellationToken) ?? throw new ArgumentException($"Category with given id {id} doesn't exist. Action is terminated");

                    if (recipe.RecipeCategories.FirstOrDefault(x => x.CategoryId == id) is not null)
                    {
                        continue;
                    }

                    newCategories.Add(new RecipeCategory
                    {
                        CategoryId = id,
                        RecipeId = request.AddCategoriesDto.RecipeId
                    });
                }

                if (newCategories.Count == 0)
                {
                    return Result.Success("This recipe already contains this categories.");
                }

                await UnitOfWork.RecipeRepository.AddRecipeCategoriesAsync(newCategories, cancellationToken);

                if (await UnitOfWork.Complete())
                {
                    return Result.Success("Successfully added categories.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}