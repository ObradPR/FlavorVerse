using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Ingredient;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FluentValidation;

namespace FlavorVerse.Application.BusinessLogic.Ingredients.Commands.Admin;

public class AddIngredientCommand : ICommand
{
    public AddIngredientDto IngredientDto { get; set; }

    public AddIngredientCommand(AddIngredientDto ingredientDto) => IngredientDto = ingredientDto;

    // Validators
    public class AddIngredientValidtion : AbstractValidator<AddIngredientDto>
    {
        public AddIngredientValidtion(IUnitOfWork unitOfWork)
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name property is required.")
                .MaximumLength(30)
                .WithMessage("Name can have at most 30 characters.")
                .MustAsync(async (name, cancellationToken) =>
                {
                    return !await unitOfWork.IngredientRepoistory.IngredientExistByNameAsync(name, cancellationToken);
                })
                .WithMessage("Ingredient with this name already exists.");
        }
    }

    // Handler
    public class AddIngredientHandler : BaseHandler<AddIngredientDto>, ICommandHandler<AddIngredientCommand>
    {
        public AddIngredientHandler(ITransactionService transactionService, IUnitOfWork unitOfWork, IValidator<AddIngredientDto> validator) : base(transactionService, unitOfWork, validator)
        {
        }

        public async Task<Result> Handle(AddIngredientCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await Validator.ValidateAsync(request.IngredientDto, cancellationToken);

            if (!validationResult.IsValid)
            {
                return ValidationError.FailureWithValidationResult<AddIngredientDto>(validationResult);
            }

            var transactionId = Guid.NewGuid();

            var newIngredientId = await UnitOfWork.IngredientRepoistory.GetNewIngredientIdAsync();

            return await TransactionService.TryProcess(transactionId, newIngredientId, eEntityType.Ingredient, eActionType.Insert, UserContext.CurrentUserId, async () =>
            {
                var ingredient = new Ingredient
                {
                    Name = request.IngredientDto.Name,
                    CreatedAt = DateTime.UtcNow,
                    IsActive = true
                };

                await UnitOfWork.IngredientRepoistory.AddAsync(ingredient, cancellationToken);

                if (await UnitOfWork.Complete())
                {
                    return Result.Success("Successfully created ingredient.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}