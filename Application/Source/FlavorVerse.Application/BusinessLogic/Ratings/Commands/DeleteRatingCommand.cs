using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FlavorVerse.Common;

namespace FlavorVerse.Application.BusinessLogic.Ratings.Commands;

public class DeleteRatingCommand : ICommand
{
    public Guid Id { get; set; }

    public DeleteRatingCommand(Guid id) => Id = id;

    // Handler
    public class DeleteRatingHandler : BaseHandler, ICommandHandler<DeleteRatingCommand>
    {
        public DeleteRatingHandler(ITransactionService transactionService, IUnitOfWork unitOfWork) : base(transactionService, unitOfWork)
        {
        }

        public async Task<Result> Handle(DeleteRatingCommand request, CancellationToken cancellationToken)
        {
            var adminRole = UserContext.CurrentRoles.Find(x => x.Equals(Constants.ADMIN));

            var rating = await UnitOfWork.RatingRepository.GetRatingByIdAsync(request.Id, cancellationToken);

            if (rating is null)
            {
                return Result.Failure(Error<Rating>.NotFound);
            }

            if (string.IsNullOrEmpty(adminRole) && rating.UserId != UserContext.CurrentUserId)
            {
                return Result.Failure(Error.ActionForbidden);
            }

            var transactionId = Guid.NewGuid();

            return await TransactionService.TryProcess(transactionId, rating.Id, eEntityType.Rating, eActionType.Delete, UserContext.CurrentUserId, async () =>
            {
                if (!rating.IsActive)
                {
                    return Result.Success("Recipe is already deleted.");
                }

                rating.IsActive = false;
                rating.DeletedAt = DateTime.UtcNow;
                rating.DeletedBy = UserContext.CurrentUserId;

                if (await UnitOfWork.Complete())
                {
                    return Result.Success("Successfully deleted.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}