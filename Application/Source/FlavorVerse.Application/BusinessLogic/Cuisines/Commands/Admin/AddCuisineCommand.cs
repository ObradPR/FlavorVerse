using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Cuisine;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FluentValidation;

namespace FlavorVerse.Application.BusinessLogic.Cuisines.Commands.Admin;

public class AddCuisineCommand : ICommand
{
    public AddCuisineDto CuisineDto { get; set; }

    public AddCuisineCommand(AddCuisineDto cuisineDto) => CuisineDto = cuisineDto;

    // Validators
    public class AddCuisineValidtion : AbstractValidator<AddCuisineDto>
    {
        public AddCuisineValidtion(IUnitOfWork unitOfWork)
        {
            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("Description property is required.")
                .MaximumLength(100)
                .WithMessage("Description can have at most 100 characters.");

            RuleFor(x => x.Image)
                .NotEmpty()
                .WithMessage("Image property is required.")
                .MaximumLength(255)
                .WithMessage("Image url can have at most 255 characters.");

            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name property is required.")
                .MaximumLength(30)
                .WithMessage("Name can have at most 30 characters.")
                .MustAsync(async (name, cancellationToken) =>
                {
                    return !await unitOfWork.CuisineRepository.CuisineExistByNameAsync(name, cancellationToken);
                })
                .WithMessage("Cuisine with this name already exists.");
        }
    }

    // Handler
    public class AddCuisineHandler : BaseHandler<AddCuisineDto>, ICommandHandler<AddCuisineCommand>
    {
        public AddCuisineHandler(ITransactionService transactionService, IUnitOfWork unitOfWork, IValidator<AddCuisineDto> validator) : base(transactionService, unitOfWork, validator)
        {
        }

        public async Task<Result> Handle(AddCuisineCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await Validator.ValidateAsync(request.CuisineDto, cancellationToken);

            if (!validationResult.IsValid)
            {
                return ValidationError.FailureWithValidationResult<AddCuisineDto>(validationResult);
            }

            var transactionId = Guid.NewGuid();

            var newCuisineId = await UnitOfWork.CuisineRepository.GetNewCuisineIdAsync();

            return await TransactionService.TryProcess<int, string>(transactionId, newCuisineId, eEntityType.Cuisine, eActionType.Insert, UserContext.CurrentUserId, async () =>
            {
                var cuisine = new Cuisine
                {
                    Name = request.CuisineDto.Name,
                    Description = request.CuisineDto.Description,
                    Image = request.CuisineDto.Image,
                    CreatedAt = DateTime.UtcNow,
                    IsActive = true
                };

                await UnitOfWork.CuisineRepository.AddAsync(cuisine, cancellationToken);

                if (await UnitOfWork.Complete())
                {
                    return Result.Success("Successfully created cuisine.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}