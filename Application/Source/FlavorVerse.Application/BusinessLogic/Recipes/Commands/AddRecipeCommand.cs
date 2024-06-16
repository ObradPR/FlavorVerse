using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Recipe;
using FlavorVerse.Application.Helpers;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FluentValidation;

namespace FlavorVerse.Application.BusinessLogic.Recipes.Commands;

public class AddRecipeCommand : ICommand
{
    public AddRecipeDto RecipeDto { get; set; }

    public AddRecipeCommand(AddRecipeDto recipetDto) => RecipeDto = recipetDto;

    // Validators
    public class AddRecipeValidtion : AbstractValidator<AddRecipeDto>
    {
        public AddRecipeValidtion(IUnitOfWork unitOfWork)
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage("Title property is required.")
                .MaximumLength(100)
                .WithMessage("Title can have at most 100 characters.");

            RuleFor(x => x.Image)
                .NotNull()
                .WithMessage("Recipe picture is required.")
                .Must(PictureValidation.BeAValidImage)
                .WithMessage("Only jpg, jpeg, and png files are allowed.")
                .Must(PictureValidation.BeAReasonableSize)
                .WithMessage("Image size should not exceed 5MB.");

            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("Description property is required.")
                .MaximumLength(500)
                .WithMessage("Description can have at most 500 characters.");

            RuleFor(x => x.CookingTime)
                .NotEmpty()
                .WithMessage("Cooking time property is required.")
                .MaximumLength(20)
                .WithMessage("Cooking time can have at most 20 characters.");

            RuleFor(x => x.Servings)
                .NotEmpty()
                .WithMessage("Servings is required.")
                .GreaterThan(0)
                .WithMessage("Servings must be whole positive number.");

            RuleFor(x => x.Instructions)
                .NotEmpty()
                .WithMessage("Instructions property is required.")
                .MaximumLength(1000)
                .WithMessage("Instructions can have at most 1000 characters.");

            RuleFor(x => x.MealTypeId)
               .NotEmpty()
               .WithMessage("Meal type id is required.")
               .GreaterThan(0)
               .WithMessage("Meal type id must be whole positive number.")
               .MustAsync(unitOfWork.MealTypeRepository.MealTypeExistByIdAsync)
               .WithMessage("Meal type with given id doesn't exists.");

            RuleFor(x => x.DifficultyCookingId)
               .NotEmpty()
               .WithMessage("Difficulty level id is required.")
               .GreaterThan(0)
               .WithMessage("Difficulty id must be whole positive number.")
               .MustAsync(unitOfWork.DifficultyCookingRepository.DifficultyCookingExistByIdAsync)
               .WithMessage("Difficulty cooking with given id doesn't exists.");

            RuleFor(x => x.MainCategoryId)
               .NotEmpty()
               .WithMessage("Main category id is required.")
               .GreaterThan(0)
               .WithMessage("Main category id must be whole positive number.")
               .MustAsync(unitOfWork.CategoryRepository.CategoryExistByIdAsync)
               .WithMessage("Category with given id doesn't exists.");

            RuleFor(x => x.MainCuisineId)
               .NotEmpty()
               .WithMessage("Main cuisine id id is required.")
               .GreaterThan(0)
               .WithMessage("Main cuisine id must be whole positive number.")
               .MustAsync(unitOfWork.CuisineRepository.CuisineExistByIdAsync)
               .WithMessage("Cuisine with given id doesn't exists.");
        }
    }

    // Handler
    public class AddRecipeHandler : BaseHandler<AddRecipeDto>, ICommandHandler<AddRecipeCommand>
    {
        public AddRecipeHandler(ITransactionService transactionService, IUnitOfWork unitOfWork, IValidator<AddRecipeDto> validator) : base(transactionService, unitOfWork, validator)
        {
        }

        public async Task<Result> Handle(AddRecipeCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await Validator.ValidateAsync(request.RecipeDto, cancellationToken);

            if (!validationResult.IsValid)
            {
                return ValidationError.FailureWithValidationResult<AddRecipeDto>(validationResult);
            }

            var dietaryInfo = await UnitOfWork.DietaryInfoRepository
                .GetDietaryInfoByStatsAsync(
                request.RecipeDto.GlutenFree ?? false,
                request.RecipeDto.DairyFree ?? false,
                request.RecipeDto.Vegetarian ?? false,
                request.RecipeDto.Vegan ?? false, cancellationToken);

            int dietaryInfoId;

            if (dietaryInfo is null)
            {
                dietaryInfoId = 1;
            }
            else
            {
                dietaryInfoId = dietaryInfo.Id;
            }

            var transactionId = Guid.NewGuid();
            var newRecipeId = Guid.NewGuid();
            var newNutritionId = Guid.NewGuid();

            return await TransactionService.TryProcess(transactionId, newRecipeId, eEntityType.Recipe, eActionType.Insert, UserContext.CurrentUserId, async () =>
            {
                var calories =
                    (request.RecipeDto.Protein ?? 0) * 4 +
                    (request.RecipeDto.Carbohydrates ?? 0) * 4 +
                    (request.RecipeDto.Fat ?? 0) * 9;

                var nutrition = new Nutrition
                {
                    Id = newNutritionId,
                    Calories = calories,
                    Protein = request.RecipeDto.Protein,
                    Carbohydrates = request.RecipeDto.Carbohydrates,
                    Fat = request.RecipeDto.Fat,
                    Fiber = request.RecipeDto.Fiber,
                    IsActive = true,
                    CreatedAt = DateTime.UtcNow
                };

                var recipeCuisine = new RecipeCuisine
                {
                    CuisineId = request.RecipeDto.MainCuisineId,
                    RecipeId = newRecipeId,
                };

                var recipeCategory = new RecipeCategory
                {
                    CategoryId = request.RecipeDto.MainCategoryId,
                    RecipeId = newRecipeId
                };

                var filePath = Path.Combine("https://example.com/images", request.RecipeDto.Image.FileName.ToLower());

                var recipe = new Recipe
                {
                    Id = newRecipeId,
                    Title = request.RecipeDto.Title,
                    UserId = UserContext.CurrentUserId,
                    Image = filePath,
                    Description = request.RecipeDto.Description,
                    CookingTime = request.RecipeDto.CookingTime,
                    Servings = request.RecipeDto.Servings,
                    DifficultyId = request.RecipeDto.DifficultyCookingId,
                    DietaryInfoId = dietaryInfoId,
                    NutritionId = newNutritionId,
                    Featured = false,
                    Instructions = request.RecipeDto.Instructions,
                    MealTypeId = request.RecipeDto.MealTypeId,
                    IsActive = true,
                    CreatedAt = DateTime.UtcNow
                };

                await UnitOfWork.RecipeRepository.AddAsync(recipe, nutrition, recipeCuisine, recipeCategory, cancellationToken);

                if (await UnitOfWork.Complete())
                {
                    return Result.Success("Successfully created recipe.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}