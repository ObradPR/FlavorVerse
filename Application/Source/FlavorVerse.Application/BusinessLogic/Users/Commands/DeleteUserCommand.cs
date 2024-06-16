using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Auth;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;

namespace FlavorVerse.Application.BusinessLogic.Users.Commands;

public class DeleteUserCommand : ICommand
{
    public Guid Id { get; set; }

    public DeleteUserCommand(Guid id) => Id = id;

    public class DeleteUserHandler : BaseHandler, ICommandHandler<DeleteUserCommand>
    {
        public DeleteUserHandler(ITransactionService transactionService, IUnitOfWork unitOfWork) : base(transactionService, unitOfWork)
        {
        }

        public async Task<Result> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = await UnitOfWork.UserRepository.GetUserByIdAsync(request.Id, cancellationToken);

            if (user is null)
            {
                return Result.Failure(Error<User>.NotFound);
            }

            var transactionId = Guid.NewGuid();

            return await TransactionService.TryProcess<Guid, string>(transactionId, user.Id, eEntityType.User, eActionType.Delete, UserContext.CurrentUserId, async () =>
            {
                user.IsActive = false;
                user.DeletedAt = DateTime.UtcNow;
                user.DeletedBy = UserContext.CurrentUserId;
                user.ModifiedAt = DateTime.UtcNow;
                user.ModifiedBy = UserContext.CurrentUserId;

                if (await UnitOfWork.Complete())
                {
                    return Result.Success("Successfully deleted user!");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}