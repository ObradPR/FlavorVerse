using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Nutrition;
using FlavorVerse.Application.Dtos.Rating;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FluentValidation;

namespace FlavorVerse.Application.BusinessLogic.Nutritions.Commands;

public class UpdateNutritionCommand : ICommand
{
    public Guid Id { get; set; }
    public UpdateNutritionDto NutritionDto { get; set; }

    public UpdateNutritionCommand(Guid id, UpdateNutritionDto nutrition)
    {
        Id = id;
        NutritionDto = nutrition;
    }

    // Validators
    public class UpdateNutritionValidation : AbstractValidator<UpdateNutritionDto>
    {
        public UpdateNutritionValidation()
        {
            RuleFor(x => x.Protein)
                .GreaterThanOrEqualTo(0)
                .When(x => x.Protein.HasValue)
                .WithMessage("Protein must be greater than or equal to zero if provided.");

            RuleFor(x => x.Carbohydrates)
                .GreaterThanOrEqualTo(0)
                .When(x => x.Carbohydrates.HasValue)
                .WithMessage("Carbs must be greater than or equal to zero if provided.");

            RuleFor(x => x.Fat)
                .GreaterThanOrEqualTo(0)
                .When(x => x.Fat.HasValue)
                .WithMessage("Fats must be greater than or equal to zero if provided.");

            RuleFor(x => x.Fiber)
                .GreaterThanOrEqualTo(0)
                .When(x => x.Fiber.HasValue)
                .WithMessage("Fiber must be greater than or equal to zero if provided.");
        }
    }

    // Handlers
    public class UpdateNutritionHandler : BaseHandler<UpdateNutritionDto>, ICommandHandler<UpdateNutritionCommand>
    {
        public UpdateNutritionHandler(ITransactionService transactionService, IUnitOfWork unitOfWork, IValidator<UpdateNutritionDto> validator) : base(transactionService, unitOfWork, validator)
        {
        }

        public async Task<Result> Handle(UpdateNutritionCommand request, CancellationToken cancellationToken)
        {
            var adminRole = UserContext.CurrentRoles.Find(x => x.Equals(Constants.ADMIN));

            var nutrition = await UnitOfWork.NutritionRepository.GetNutritionByIdAsync(request.Id, cancellationToken);

            if (nutrition is null)
            {
                return Result.Failure(Error<Nutrition>.NotFound);
            }

            var recipe = await UnitOfWork.RecipeRepository.GetRecipeByNutritionIdAsync(request.Id, cancellationToken);

            if (recipe is null)
            {
                return Result.Failure(Error<Recipe>.NotFound);
            }

            if (string.IsNullOrEmpty(adminRole) && recipe.UserId != UserContext.CurrentUserId)
            {
                return Result.Failure(Error.ActionForbidden);
            }

            if (request.NutritionDto.IsActive is null
                && request.NutritionDto.Protein is null
                && request.NutritionDto.Carbohydrates is null
                && request.NutritionDto.Fat is null
                && request.NutritionDto.Fiber is null)
            {
                return Result.Failure(Error.NullValue);
            }

            var validationResult = await Validator.ValidateAsync(request.NutritionDto, cancellationToken);

            if (!validationResult.IsValid)
            {
                return ValidationError.FailureWithValidationResult<UpdateNutritionDto>(validationResult);
            }

            var transactionId = Guid.NewGuid();

            return await TransactionService.TryProcess(transactionId, request.Id, eEntityType.Nutrition, eActionType.Update, UserContext.CurrentUserId, async () =>
            {
                if (request.NutritionDto.IsActive == false)
                {
                    nutrition.DeletedAt = DateTime.UtcNow;
                    nutrition.DeletedBy = UserContext.CurrentUserId;
                    nutrition.IsActive = false;
                }
                else if (request.NutritionDto.IsActive == true)
                {
                    nutrition.IsActive = true;
                }

                nutrition.Protein = request.NutritionDto.Protein ?? nutrition.Protein;
                nutrition.Carbohydrates = request.NutritionDto.Carbohydrates ?? nutrition.Carbohydrates;
                nutrition.Fat = request.NutritionDto.Fat ?? nutrition.Fat;
                nutrition.Fiber = request.NutritionDto.Fiber ?? nutrition.Fiber;
                nutrition.Calories = ((request.NutritionDto.Protein ?? nutrition.Protein) * 4) +
                                     ((request.NutritionDto.Carbohydrates ?? nutrition.Carbohydrates) * 4) +
                                     ((request.NutritionDto.Fat ?? nutrition.Fat) * 9);
                nutrition.ModifiedAt = DateTime.UtcNow;
                nutrition.ModifiedBy = UserContext.CurrentUserId;

                if (await UnitOfWork.Complete())
                {
                    return Result.Success("Successfully updated nutrition.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}