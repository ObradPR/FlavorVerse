using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FluentValidation;
using FlavorVerse.Application.Dtos.Cuisine;

namespace FlavorVerse.Application.BusinessLogic.Cuisines.Commands.Admin;

public class UpdateCuisineCommand : ICommand
{
    public int Id { get; set; }
    public UpdateCuisineDto Cuisine { get; set; }

    public UpdateCuisineCommand(int id, UpdateCuisineDto cuisine)
    {
        Id = id;
        Cuisine = cuisine;
    }

    // Validators
    public class UpdateCuisineValidation : AbstractValidator<UpdateCuisineDto>
    {
        public UpdateCuisineValidation(IUnitOfWork unitOfWork)
        {
            RuleFor(x => x.Name)
                .MaximumLength(30)
                .WithMessage("Cuisine name must be at most 30 characters long.")
                .MustAsync(async (name, cancellationToken) =>
                {
                    return !await unitOfWork.CuisineRepository.CuisineExistByNameAsync(name, cancellationToken);
                })
                .WithMessage("Cuisine with this name already exist. Or if you included same name for update jsut set it to null in request.");

            RuleFor(x => x.Description)
                .MaximumLength(100)
                .WithMessage("Cuisine description must be at most 100 characters long.");

            RuleFor(x => x.Image)
                .MaximumLength(255)
                .WithMessage("Cuisine image url must be at most 255 characters long.");
        }
    }

    // Handlers
    public class UpdateCuisineHandler : BaseHandler<UpdateCuisineDto>, ICommandHandler<UpdateCuisineCommand>
    {
        public UpdateCuisineHandler(ITransactionService transactionService, IUnitOfWork unitOfWork, IValidator<UpdateCuisineDto> validator) : base(transactionService, unitOfWork, validator)
        {
        }

        public async Task<Result> Handle(UpdateCuisineCommand request, CancellationToken cancellationToken)
        {
            var cuisine = await UnitOfWork.CuisineRepository.GetCuisineByIdAsync(request.Id, cancellationToken);

            if (cuisine is null)
            {
                return Result.Failure(Error<Cuisine>.NotFound);
            }

            if (string.IsNullOrEmpty(request.Cuisine.Name)
                && request.Cuisine.Description is null
                && request.Cuisine.Image is null
                && request.Cuisine.IsActive is null)
            {
                return Result.Failure(Error.NullValue);
            }

            var validationResult = await Validator.ValidateAsync(request.Cuisine, cancellationToken);

            if (!validationResult.IsValid)
            {
                return ValidationError.FailureWithValidationResult<UpdateCuisineDto>(validationResult);
            }

            var transactionId = Guid.NewGuid();

            return await TransactionService.TryProcess<int, string>(transactionId, request.Id, eEntityType.Cuisine, eActionType.Update, UserContext.CurrentUserId, async () =>
            {
                cuisine.Name = request.Cuisine.Name ?? cuisine.Name;
                cuisine.Description = request.Cuisine.Description ?? cuisine.Description;
                cuisine.Image = request.Cuisine.Image ?? cuisine.Image;
                cuisine.IsActive = request.Cuisine.IsActive ?? cuisine.IsActive;
                cuisine.ModifiedAt = DateTime.UtcNow;
                cuisine.ModifiedBy = UserContext.CurrentUserId;

                if (request.Cuisine.IsActive == false)
                {
                    cuisine.DeletedAt = DateTime.UtcNow;
                    cuisine.DeletedBy = UserContext.CurrentUserId;
                }

                if (await UnitOfWork.Complete())
                {
                    return Result.Success<string>("Successfully updated cuisine.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}