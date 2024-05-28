using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Enums;

namespace FlavorVerse.Application.Abstractions
{
    public interface ITransactionService
    {
        Task<Result<TValue>> TryProcess<TValue>(Guid transactionId, Guid entityId, eEntityType entityType, eActionType actionType, Guid executedById, Func<Task<Result<TValue>>> action, CancellationToken cancellationToken);
    }
}