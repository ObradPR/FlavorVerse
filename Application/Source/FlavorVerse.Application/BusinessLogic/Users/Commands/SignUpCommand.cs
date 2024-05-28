using AutoMapper;
using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Auth;
using FlavorVerse.Application.Helpers;
using FlavorVerse.Application.Identity.Abstractions;
using FlavorVerse.Application.Identity.Services;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FluentValidation;

namespace FlavorVerse.Application.BusinessLogic.Users.Commands;

public sealed class SignUpCommand : ICommand<AuthResponseDto>
{
    public SignUpDto UserSignUp { get; set; }

    public SignUpCommand(SignUpDto user) => UserSignUp = user;

    // Validators
    public class SignUpValidator : AbstractValidator<SignUpDto>
    {
        public SignUpValidator(IUnitOfWork unitOfWork)
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("First name is required.")
                .MaximumLength(20)
                .WithMessage("First name must be at most 20 characters long.")
                .MinimumLength(2)
                .WithMessage("First name must be at least 2 characters long.");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("Last name is required.")
                .MaximumLength(30)
                .WithMessage("Last name must be at most 30 characters long.")
                .MinimumLength(2)
                .WithMessage("Last name must be at least 2 characters long.");

            RuleFor(x => x.Email)
                   .NotEmpty()
                   .WithMessage("Email is required.")
                   .EmailAddress()
                   .WithMessage("Invalid email format.")
                   .MaximumLength(100)
                   .WithMessage("Email must be at most 100 characters long.")
                   .MustAsync(async (email, cancellationToken) =>
                   {
                       return !await unitOfWork.UserRepository.UserExistByEmailAsync(email, cancellationToken);
                   })
                   .WithMessage("Account with this email already exists.");

            RuleFor(x => x.Phone)
                .NotEmpty()
                .WithMessage("Phone is required.")
                .Matches(@"^\d+$")
                .WithMessage("Phone number must contain only numbers.")
                .MaximumLength(15)
                .WithMessage("Phone number must be at most 15 digits long.")
                .MinimumLength(10)
                .WithMessage("Phone number must be at least 10 digits long.");

            RuleFor(x => x.Password)
                  .NotEmpty()
                  .WithMessage("Password is required.")
                  .MinimumLength(8)
                  .WithMessage("Password must be at least 8 characters long.")
                  .Matches("[A-Z]")
                  .WithMessage("Password must contain at least one uppercase letter.")
                  .Matches("[a-z]")
                  .WithMessage("Password must contain at least one lowercase letter.")
                  .Matches("[0-9]")
                  .WithMessage("Password must contain at least one digit.")
                  .Matches(@"[!@#$%^&*(),.?"":{ }|<>]")
                  .WithMessage("Password must contain at least one special character.");

            RuleFor(x => x.ConfirmPassword)
                .Equal(x => x.Password)
                .WithMessage("Passwords do not match.");

            RuleFor(x => x.DateOfBirth)
                .NotEmpty()
                .NotNull()
                .WithMessage("Date of birth is required.")
                .Must(DateValidation.BeInThePast)
                .WithMessage("Date of birth must be in the past.")
                .Must(DateValidation.BeAValidAge)
                .WithMessage("Date of birth is not valid. You must be at least 12yso and not older than 100yso");
        }
    }

    // Handler
    public class SignUpHandler : BaseHandler<SignUpDto>, ICommandHandler<SignUpCommand, AuthResponseDto>
    {
        private readonly IJwtService _jwtService;

        public SignUpHandler(ITransactionService transactionService, IUnitOfWork unitOfWork, IMapper mapper, IValidator<SignUpDto> validator, IJwtService jwtService) : base(transactionService, unitOfWork, mapper, validator)
        {
            _jwtService = jwtService;
        }

        public async Task<Result<AuthResponseDto>> Handle(SignUpCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await Validator.ValidateAsync(request.UserSignUp, cancellationToken);

            if (!validationResult.IsValid)
            {
                return ValidationError.FailureWithValidationResult<AuthResponseDto>(validationResult);
            }

            var transactionId = Guid.NewGuid();
            var newUserId = Guid.NewGuid();

            return await TransactionService.TryProcess<AuthResponseDto>(transactionId, newUserId, eEntityType.User, eActionType.Insert, newUserId, async () =>
            {
                var user = new User
                {
                    Id = newUserId,
                    FirstName = request.UserSignUp.FirstName,
                    LastName = request.UserSignUp.LastName,
                    Email = request.UserSignUp.Email,
                    Phone = request.UserSignUp.Phone,
                    Password = UserService.HashPassword(request.UserSignUp.Password),
                    DateOfBirth = request.UserSignUp.DateOfBirth,
                    CreatedAt = DateTime.UtcNow,
                    IsActive = true
                };

                var userRole = new UserRole
                {
                    RoleId = (int)eUserRole.Member,
                    UserId = newUserId
                };

                await UnitOfWork.UserRepository.AddAsync(user, userRole, cancellationToken);

                if (await UnitOfWork.Complete())
                {
                    var response = new AuthResponseDto
                    {
                        DisplayName = user.FirstName + " " + user.LastName,
                        Token = _jwtService.GenerateJwtToken(newUserId, [eUserRole.Member.ToString()]),
                    };

                    return Result.Success(response);
                }

                return Result.Failure<AuthResponseDto>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}