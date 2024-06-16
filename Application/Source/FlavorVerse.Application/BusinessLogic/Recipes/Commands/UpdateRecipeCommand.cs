using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.BusinessLogic.Nutritions.Commands;
using FlavorVerse.Application.Dtos.Nutrition;
using FlavorVerse.Application.Dtos.Recipe;
using FlavorVerse.Application.Helpers;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Entities.Application_lu;
using FlavorVerse.Domain.Repositories;
using FluentValidation;

namespace FlavorVerse.Application.BusinessLogic.Recipes.Commands;

public class UpdateRecipeCommand : ICommand
{
    public Guid Id { get; set; }
    public UpdateRecipeDto RecipeDto { get; set; }

    public UpdateRecipeCommand(Guid id, UpdateRecipeDto recipe)
    {
        Id = id;
        RecipeDto = recipe;
    }

    // Validators
    public class UpdateRecipeValidation : AbstractValidator<UpdateRecipeDto>
    {
        public UpdateRecipeValidation()
        {
            RuleFor(x => x.Title)
                .MaximumLength(100)
                .When(x => !string.IsNullOrEmpty(x.Title))
                .WithMessage("Title can have at most 100 characters.");

            RuleFor(x => x.Image)
                .Must(PictureValidation.BeAValidImage)
                .When(x => x.Image is not null)
                .WithMessage("Only jpg, jpeg, and png files are allowed.")
                .Must(PictureValidation.BeAReasonableSize)
                .When(x => x.Image is not null)
                .WithMessage("Image size should not exceed 5MB.");

            RuleFor(x => x.Description)
                .MaximumLength(500)
                .When(x => !string.IsNullOrEmpty(x.Description))
                .WithMessage("Description can have at most 500 characters.");

            RuleFor(x => x.CookingTime)
                .MaximumLength(20)
                .When(x => !string.IsNullOrEmpty(x.CookingTime))
                .WithMessage("Cooking time can have at most 20 characters.");

            RuleFor(x => x.Servings)
                .GreaterThan(0)
                .When(x => x.Servings.HasValue)
                .WithMessage("Servings must be whole positive number.");

            RuleFor(x => x.Instructions)
                .MaximumLength(1000)
                .When(x => !string.IsNullOrEmpty(x.Instructions))
                .WithMessage("Instructions can have at most 1000 characters.");

            RuleFor(x => x.MealTypeId)
               .GreaterThan(0)
               .When(x => x.MealTypeId.HasValue)
               .WithMessage("Meal type id must be whole positive number.");

            RuleFor(x => x.DifficultyCookingId)
               .GreaterThan(0)
               .When(x => x.MealTypeId.HasValue)
               .WithMessage("Difficulty id must be whole positive number.");
        }
    }

    // Handlers
    public class UpdateRecipeHandler : BaseHandler<UpdateRecipeDto>, ICommandHandler<UpdateRecipeCommand>
    {
        public UpdateRecipeHandler(ITransactionService transactionService, IUnitOfWork unitOfWork, IValidator<UpdateRecipeDto> validator) : base(transactionService, unitOfWork, validator)
        {
        }

        public async Task<Result> Handle(UpdateRecipeCommand request, CancellationToken cancellationToken)
        {
            var adminRole = UserContext.CurrentRoles.Find(x => x.Equals(Constants.ADMIN));

            var recipe = await UnitOfWork.RecipeRepository.GetRecipeByIdAsync(request.Id, cancellationToken);

            if (recipe is null)
            {
                return Result.Failure(Error<Recipe>.NotFound);
            }

            if (string.IsNullOrEmpty(adminRole) && recipe.UserId != UserContext.CurrentUserId)
            {
                return Result.Failure(Error.ActionForbidden);
            }

            if (request.RecipeDto.IsActive is null
                && request.RecipeDto.Title is null
                && request.RecipeDto.DifficultyCookingId is null
                && request.RecipeDto.MealTypeId is null
                && request.RecipeDto.Instructions is null
                && request.RecipeDto.Servings is null
                && request.RecipeDto.CookingTime is null
                && request.RecipeDto.Description is null
                && request.RecipeDto.Image is null
                && request.RecipeDto.Vegan is null
                && request.RecipeDto.Vegetarian is null
                && request.RecipeDto.GlutenFree is null
                && request.RecipeDto.DairyFree is null)
            {
                return Result.Failure(Error.NullValue);
            }

            var validationResult = await Validator.ValidateAsync(request.RecipeDto, cancellationToken);

            if (!validationResult.IsValid)
            {
                return ValidationError.FailureWithValidationResult<UpdateRecipeDto>(validationResult);
            }

            if (request.RecipeDto.MealTypeId is int mealTypeId)
            {
                var exist = await UnitOfWork.MealTypeRepository.MealTypeExistByIdAsync(mealTypeId, cancellationToken);

                if (!exist)
                {
                    return Result.Failure(Error<MealType_lu>.NotFound);
                }
            }

            if (request.RecipeDto.DifficultyCookingId is int difficultyCookingId)
            {
                var exist = await UnitOfWork.DifficultyCookingRepository.DifficultyCookingExistByIdAsync(difficultyCookingId, cancellationToken);

                if (!exist)
                {
                    return Result.Failure(Error<DifficultyCooking_lu>.NotFound);
                }
            }

            var transactionId = Guid.NewGuid();

            return await TransactionService.TryProcess(transactionId, request.Id, eEntityType.Recipe, eActionType.Update, UserContext.CurrentUserId, async () =>
            {
                if (request.RecipeDto.IsActive == false)
                {
                    recipe.DeletedAt = DateTime.UtcNow;
                    recipe.DeletedBy = UserContext.CurrentUserId;
                    recipe.IsActive = false;
                }
                else if (request.RecipeDto.IsActive == true)
                {
                    recipe.IsActive = true;
                }

                string? newFilePath = null;

                if (request.RecipeDto.Image is not null)
                {
                    newFilePath = Path.Combine("https://example.com/images", request.RecipeDto.Image.FileName.ToLower());
                }

                var newDieataryInfo = await UnitOfWork.DietaryInfoRepository.GetDietaryInfoByStatsAsync(
                     (request.RecipeDto.GlutenFree ?? recipe.DietaryInfo.GlutenFree),
                     (request.RecipeDto.DairyFree ?? recipe.DietaryInfo.DairyFree),
                     (request.RecipeDto.Vegetarian ?? recipe.DietaryInfo.Vegetarian),
                     (request.RecipeDto.Vegan ?? recipe.DietaryInfo.Vegan),
                     cancellationToken);

                recipe.Title = request.RecipeDto.Title ?? recipe.Title;
                recipe.Description = request.RecipeDto.Description ?? recipe.Description;
                recipe.CookingTime = request.RecipeDto.CookingTime ?? recipe.CookingTime;
                recipe.Servings = request.RecipeDto.Servings ?? recipe.Servings;
                recipe.Instructions = request.RecipeDto.Instructions ?? recipe.Instructions;
                recipe.MealTypeId = request.RecipeDto.MealTypeId ?? recipe.MealTypeId;
                recipe.DifficultyId = request.RecipeDto.DifficultyCookingId ?? recipe.DifficultyId;
                recipe.Image = newFilePath ?? recipe.Image;
                recipe.DietaryInfoId = newDieataryInfo is null ? recipe.DietaryInfoId : newDieataryInfo!.Id;
                recipe.ModifiedAt = DateTime.UtcNow;
                recipe.ModifiedBy = UserContext.CurrentUserId;

                if (await UnitOfWork.Complete())
                {
                    return Result.Success("Successfully updated recipe details.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}