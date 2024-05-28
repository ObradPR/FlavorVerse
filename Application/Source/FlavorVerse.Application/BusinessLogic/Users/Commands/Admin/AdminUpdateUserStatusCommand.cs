using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Status;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FluentValidation;

namespace FlavorVerse.Application.BusinessLogic.Users.Commands.Admin;

public class AdminUpdateUserStatusCommand : ICommand
{
    public Guid Id { get; set; }
    public StatusDto Status { get; set; }

    public AdminUpdateUserStatusCommand(Guid id, StatusDto status)
    {
        Id = id;
        Status = status;
    }

    // Handler
    public class AdminUpdateUserStatusHandler : BaseHandler, ICommandHandler<AdminUpdateUserStatusCommand>
    {
        public AdminUpdateUserStatusHandler(ITransactionService transactionService, IUnitOfWork unitOfWork) : base(transactionService, unitOfWork)
        {
        }

        public async Task<Result> Handle(AdminUpdateUserStatusCommand request, CancellationToken cancellationToken)
        {
            var user = await UnitOfWork.UserRepository.GetUserByIdAsync(request.Id, cancellationToken);

            if (user is null)
            {
                user = await UnitOfWork.UserRepository.GetDeletedUserByIdAsync(request.Id, cancellationToken);

                if (user is null)
                {
                    return Result.Failure(Error<User>.NotFound);
                }
            }

            var transactionId = Guid.NewGuid();

            var newStatus = request.Status.IsActive;

            var actionType = newStatus ? eActionType.Update : eActionType.Delete;

            return await TransactionService.TryProcess<string>(transactionId, user.Id, eEntityType.User, actionType, UserContext.CurrentUserId, async () =>
            {
                if (user.IsActive == newStatus)
                {
                    return Result.Success("User has this status already.");
                }

                if (newStatus)
                {
                    user.IsActive = newStatus;
                }
                else
                {
                    user.IsActive = newStatus;
                    user.DeletedAt = DateTime.UtcNow;
                    user.DeletedBy = UserContext.CurrentUserId;
                }

                user.ModifiedAt = DateTime.UtcNow;
                user.ModifiedBy = UserContext.CurrentUserId;

                if (await UnitOfWork.Complete())
                {
                    return Result.Success("Successfully edited user roles/status.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}