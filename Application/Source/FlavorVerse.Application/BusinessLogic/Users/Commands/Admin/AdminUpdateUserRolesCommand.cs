using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FluentValidation;
using FlavorVerse.Common.Enums;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Dtos.Role;

namespace FlavorVerse.Application.BusinessLogic.Users.Commands.Admin;

public class AdminUpdateUserRolesCommand : ICommand
{
    public Guid Id { get; set; }
    public RoleDto Roles { get; set; }

    public AdminUpdateUserRolesCommand(Guid id, RoleDto roles)
    {
        Id = id;
        Roles = roles;
    }

    // Validators
    public class AdminUpdateUserRolesStatusValidator : AbstractValidator<RoleDto>
    {
        public AdminUpdateUserRolesStatusValidator(IUnitOfWork unitOfWork)
        {
            RuleFor(x => x.Roles)
                .NotEmpty()
                .WithMessage("At least one role is required.")
                .MustAsync(unitOfWork.RoleRepository.RolesExistAsync)
                .WithMessage("One or more roles doesn't exist.");
        }
    }

    // Handler
    public class AdminUpdateUserRolesHandler : BaseHandler<RoleDto>, ICommandHandler<AdminUpdateUserRolesCommand>
    {
        public AdminUpdateUserRolesHandler(ITransactionService transactionService, IUnitOfWork unitOfWork, IValidator<RoleDto> validator) : base(transactionService, unitOfWork, validator)
        {
        }

        public async Task<Result> Handle(AdminUpdateUserRolesCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await Validator.ValidateAsync(request.Roles, cancellationToken);

            if (!validationResult.IsValid)
            {
                return ValidationError.FailureWithValidationResult(validationResult);
            }

            var user = await UnitOfWork.UserRepository.GetUserByIdAsync(request.Id, cancellationToken);

            if (user is null)
            {
                return Result.Failure(Error<User>.NotFound);
            }

            var transactionId = Guid.NewGuid();

            return await TransactionService.TryProcess<Guid, string>(transactionId, user.Id, eEntityType.User, eActionType.Update, UserContext.CurrentUserId, async () =>
            {
                var currentUserRoles = await UnitOfWork.RoleRepository.GetUserRolesAsync(request.Id, cancellationToken);

                var currentRoleTitles = currentUserRoles.Select(x => x.Role.Name).ToList();
                var requestedRoles = request.Roles.Roles;

                if (requestedRoles.OrderBy(x => x).SequenceEqual(currentRoleTitles.OrderBy(x => x)))
                {
                    return Result.Success("User has already the same roles");
                }

                var allRoles = await UnitOfWork.RoleRepository.GetAllAsync(cancellationToken);

                var alreadyHas = 0;
                foreach (var role in requestedRoles)
                {
                    var userRole = currentUserRoles.FirstOrDefault(x => x.Role.Name.Equals(role));

                    if (userRole is null)
                    {
                        var newUserRole = new UserRole
                        {
                            UserId = request.Id,
                            RoleId = allRoles.Where(x => x.Name.Equals(role)).Select(x => x.Id).FirstOrDefault(),
                        };

                        await UnitOfWork.RoleRepository.AddUserRoleAsync(newUserRole);
                    }
                    else
                    {
                        alreadyHas++;
                    }
                }

                if (alreadyHas == requestedRoles.Count())
                {
                    return Result.Success("User has already the same roles");
                }

                if (await UnitOfWork.Complete())
                {
                    return Result.Success("Successfully edited user roles/status.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}