using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;

namespace FlavorVerse.Application.BusinessLogic.Cuisines.Commands.Admin;

public class DeleteCuisineCommand : ICommand
{
    public int Id { get; set; }

    public DeleteCuisineCommand(int id) => Id = id;

    // Handler
    public class DeleteCuisineHandler : BaseHandler, ICommandHandler<DeleteCuisineCommand>
    {
        public DeleteCuisineHandler(ITransactionService transactionService, IUnitOfWork unitOfWork) : base(transactionService, unitOfWork)
        {
        }

        public async Task<Result> Handle(DeleteCuisineCommand request, CancellationToken cancellationToken)
        {
            var cuisine = await UnitOfWork.CuisineRepository.GetCuisineByIdAsync(request.Id, cancellationToken);

            if (cuisine is null)
            {
                return Result.Failure(Error<Cuisine>.NotFound);
            }

            var transactionId = Guid.NewGuid();

            return await TransactionService.TryProcess<int, string>(transactionId, cuisine.Id, eEntityType.Cuisine, eActionType.Delete, UserContext.CurrentUserId, async () =>
            {
                if (!cuisine.IsActive)
                {
                    return Result.Success("Cuisine is already deleted.");
                }

                cuisine.IsActive = false;
                cuisine.ModifiedAt = DateTime.UtcNow;
                cuisine.ModifiedBy = UserContext.CurrentUserId;
                cuisine.DeletedAt = DateTime.UtcNow;
                cuisine.DeletedBy = UserContext.CurrentUserId;

                if (await UnitOfWork.Complete())
                {
                    return Result.Success<string>("Successfully deleted.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}