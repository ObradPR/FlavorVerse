using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.User;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FlavorVerse.Common.Enums;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Helpers;
using FluentValidation;
using FlavorVerse.Application.Dtos.Auth;

namespace FlavorVerse.Application.BusinessLogic.Users.Commands;

public class UpdateUserProfileCommand : ICommand
{
    public Guid Id { get; set; }
    public UpdateUserProfileDto User { get; set; }

    public UpdateUserProfileCommand(Guid id, UpdateUserProfileDto user)
    {
        Id = id;
        User = user;
    }

    // Validators
    public class UpdateUserProfileValidator : AbstractValidator<UpdateUserProfileDto>
    {
        public UpdateUserProfileValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .When(x => !string.IsNullOrEmpty(x.FirstName))
                .WithMessage("First name can't be empty.")
                .MaximumLength(20)
                .WithMessage("First name must be at most 20 characters long.")
                .MinimumLength(2)
                .WithMessage("First name must be at least 2 characters long.");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .When(x => !string.IsNullOrEmpty(x.LastName))
                .WithMessage("Last name can't be empty.")
                .MaximumLength(30)
                .WithMessage("Last name must be at most 30 characters long.")
                .MinimumLength(2)
                .WithMessage("Last name must be at least 2 characters long.");

            RuleFor(x => x.Phone)
                .NotEmpty()
                .When(x => !string.IsNullOrEmpty(x.Phone))
                .WithMessage("Phone can't be empty.")
                .Matches(@"^\d+$")
                .WithMessage("Phone number must contain only numbers.")
                .MaximumLength(15)
                .WithMessage("Phone number must be at most 15 digits long.")
                .MinimumLength(10)
                .WithMessage("Phone number must be at least 10 digits long.");

            RuleFor(x => x.DateOfBirth)
                .NotEmpty()
                .When(x => x.DateOfBirth.HasValue)
                .WithMessage("Date of birth can't be empty.");

            RuleFor(x => x.DateOfBirth)
                .Must(DateValidation.BeInThePast)
                .When(x => x.DateOfBirth.HasValue)
                .WithMessage("Date of birth must be in the past.");

            RuleFor(x => x.DateOfBirth)
                .Must(DateValidation.BeAValidAge)
                .When(x => x.DateOfBirth.HasValue)
                .WithMessage("Date of birth is not valid. You must be at least 12 years old and not older than 100 years old.");
        }
    }

    // Handler
    public class UpdateUserProfileHandler : BaseHandler<UpdateUserProfileDto>, ICommandHandler<UpdateUserProfileCommand>
    {
        public UpdateUserProfileHandler(ITransactionService transactionService, IUnitOfWork unitOfWork, IValidator<UpdateUserProfileDto> validator) : base(transactionService, unitOfWork, validator)
        {
        }

        public async Task<Result> Handle(UpdateUserProfileCommand request, CancellationToken cancellationToken)
        {
            var userInDb = await UnitOfWork.UserRepository.GetUserByIdAsync(request.Id, cancellationToken);

            if (userInDb is null)
            {
                return Result.Failure(Error<User>.NotFound);
            }

            if (request.User.DateOfBirth is null
                && string.IsNullOrEmpty(request.User.FirstName)
                && string.IsNullOrEmpty(request.User.LastName)
                && string.IsNullOrEmpty(request.User.Phone))
            {
                return Result.Failure(Error.NullValue);
            }

            var validationResult = await Validator.ValidateAsync(request.User, cancellationToken);

            if (!validationResult.IsValid)
            {
                return ValidationError.FailureWithValidationResult<AuthResponseDto>(validationResult);
            }

            var transactionId = Guid.NewGuid();

            return await TransactionService.TryProcess<string>(transactionId, userInDb.Id, eEntityType.User, eActionType.Update, UserContext.CurrentUserId, async () =>
            {
                userInDb.FirstName = request.User.FirstName ?? userInDb.FirstName;
                userInDb.LastName = request.User.LastName ?? userInDb.LastName;
                userInDb.Phone = request.User.Phone ?? userInDb.Phone;
                userInDb.DateOfBirth = request.User.DateOfBirth ?? userInDb.DateOfBirth;
                userInDb.ModifiedAt = DateTime.UtcNow;
                userInDb.ModifiedBy = UserContext.CurrentUserId;

                if (await UnitOfWork.Complete())
                {
                    return Result.Success("Successfully updated user.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}