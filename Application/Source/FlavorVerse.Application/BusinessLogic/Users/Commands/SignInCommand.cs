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

public sealed class SignInCommand : ICommand<AuthResponseDto>
{
    public SignInDto UserSignIn { get; set; }

    public SignInCommand(SignInDto user) => UserSignIn = user;

    // Validators
    public class SignInValidator : AbstractValidator<SignInDto>
    {
        public SignInValidator(IUnitOfWork unitOfWork)
        {
            RuleFor(x => x.Email)
                   .NotEmpty()
                   .WithMessage("Email is required.")
                   .EmailAddress()
                   .WithMessage("Invalid email format.")
                   .MaximumLength(100)
                   .WithMessage("Email must be at most 100 characters long.")
                   .MustAsync(unitOfWork.UserRepository.UserExistByEmailAsync)
                   .WithMessage("User doesn't exists.");

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
        }
    }

    // Handler
    public class SignInHandler : BaseHandler<SignInDto>, ICommandHandler<SignInCommand, AuthResponseDto>
    {
        private readonly IJwtService _jwtService;

        public SignInHandler(ITransactionService transactionService, IUnitOfWork unitOfWork, IMapper mapper, IValidator<SignInDto> validator, IJwtService jwtService) : base(transactionService, unitOfWork, mapper, validator)
        {
            _jwtService = jwtService;
        }

        public async Task<Result<AuthResponseDto>> Handle(SignInCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await Validator.ValidateAsync(request.UserSignIn, cancellationToken);

            if (!validationResult.IsValid)
            {
                return ValidationError.FailureWithValidationResult<AuthResponseDto>(validationResult);
            }

            var user = await UnitOfWork.UserRepository.GetUserByEmailAsync(request.UserSignIn.Email, cancellationToken);

            if (user is null)
            {
                return Result.Failure<AuthResponseDto>(Error<User>.NotFound);
            }

            var passwordMatch = UserService.VerifyPassword(request.UserSignIn.Password, user.Password);

            if (!passwordMatch)
            {
                return Result.Failure<AuthResponseDto>(Error<User>.NotFound);
            }

            var signInLog = new SignInLog
            {
                Id = Guid.NewGuid(),
                RecordDate = DateTime.UtcNow,
                UserId = user.Id
            };

            await UnitOfWork.SignInLogRepository.AddAsync(signInLog, cancellationToken);

            if (await UnitOfWork.Complete())
            {
                var roles = user.UserRoles.Select(x => x.Role.Name).ToArray();

                var userMapped = Mapper.Map<AuthResponseDto>(user);
                userMapped.Token = _jwtService.GenerateJwtToken(user.Id, roles);

                return Result.Success(userMapped);
            }

            return Result.Failure<AuthResponseDto>(Error.SaveChangesFailed);
        }
    }
}