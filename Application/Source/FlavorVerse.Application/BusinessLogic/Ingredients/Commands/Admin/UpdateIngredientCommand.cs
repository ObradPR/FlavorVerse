using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FluentValidation;
using FlavorVerse.Application.Dtos.Ingredient;

namespace FlavorVerse.Application.BusinessLogic.Ingredients.Commands.Admin;

public class UpdateIngredientCommand : ICommand
{
    public int Id { get; set; }
    public UpdateIngredientDto IngredientDto { get; set; }

    public UpdateIngredientCommand(int id, UpdateIngredientDto ingredient)
    {
        Id = id;
        IngredientDto = ingredient;
    }

    // Validators
    public class UpdateIngredientValidation : AbstractValidator<UpdateIngredientDto>
    {
        public UpdateIngredientValidation(IUnitOfWork unitOfWork)
        {
            RuleFor(x => x.Name)
                .MaximumLength(30)
                .WithMessage("Ingredient name must be at most 30 characters long.")
                .MustAsync(async (name, cancellationToken) =>
                {
                    return !await unitOfWork.IngredientRepoistory.IngredientExistByNameAsync(name, cancellationToken);
                })
                .WithMessage("Ingredient with this name already exist. Or if you included same name for update jsut set it to null in request.");
        }
    }

    // Handlers
    public class UpdateIngredientHandler : BaseHandler<UpdateIngredientDto>, ICommandHandler<UpdateIngredientCommand>
    {
        public UpdateIngredientHandler(ITransactionService transactionService, IUnitOfWork unitOfWork, IValidator<UpdateIngredientDto> validator) : base(transactionService, unitOfWork, validator)
        {
        }

        public async Task<Result> Handle(UpdateIngredientCommand request, CancellationToken cancellationToken)
        {
            var ingredient = await UnitOfWork.IngredientRepoistory.GetIngredientByIdAsync(request.Id, cancellationToken);

            if (ingredient is null)
            {
                return Result.Failure(Error<Ingredient>.NotFound);
            }

            if (string.IsNullOrEmpty(request.IngredientDto.Name)
                && request.IngredientDto.IsActive is null)
            {
                return Result.Failure(Error.NullValue);
            }

            var validationResult = await Validator.ValidateAsync(request.IngredientDto, cancellationToken);

            if (!validationResult.IsValid)
            {
                return ValidationError.FailureWithValidationResult<UpdateIngredientDto>(validationResult);
            }

            var transactionId = Guid.NewGuid();

            return await TransactionService.TryProcess(transactionId, request.Id, eEntityType.Ingredient, eActionType.Update, UserContext.CurrentUserId, async () =>
            {
                ingredient.Name = request.IngredientDto.Name ?? ingredient.Name;
                ingredient.IsActive = request.IngredientDto.IsActive ?? ingredient.IsActive;
                ingredient.ModifiedAt = DateTime.UtcNow;
                ingredient.ModifiedBy = UserContext.CurrentUserId;

                if (request.IngredientDto.IsActive == false)
                {
                    ingredient.DeletedAt = DateTime.UtcNow;
                    ingredient.DeletedBy = UserContext.CurrentUserId;
                }

                if (await UnitOfWork.Complete())
                {
                    return Result.Success("Successfully updated ingredient.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}