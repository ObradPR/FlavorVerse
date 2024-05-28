using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using System.Diagnostics;
using System.Text.Json;

namespace FlavorVerse.Application.Services
{
    public sealed class TransactionService : ITransactionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TransactionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<TValue>> TryProcess<TValue>(Guid transactionId, Guid entityId, eEntityType entityTypeId, eActionType actionTypeId, Guid executedById, Func<Task<Result<TValue>>> action, CancellationToken cancellationToken)
        {
            var audit = new Audit();

            Result<TValue>? result = null;
            var timer = Stopwatch.StartNew();

            try
            {
                result = await action.Invoke();

                timer.Stop();

                if (result.IsSuccess)
                {
                    audit.IsSuccess = true;
                    audit.DetailsJson = null;
                }
                else
                {
                    throw new Exception(result.Error.ToString());
                }
            }
            catch (Exception ex)
            {
                var jsonMessage = new
                {
                    Error = ex.Message,
                };

                audit.IsSuccess = false;
                audit.DetailsJson = JsonSerializer.Serialize(jsonMessage);
            }
            finally
            {
                if (result is not null)
                {
                    audit.Id = Guid.NewGuid();
                    audit.EntityId = entityId;
                    audit.EntityTypeId = (int)entityTypeId;
                    audit.ActionTypeId = (int)actionTypeId;
                    audit.RecordDate = DateTime.UtcNow;
                    audit.ExecutedById = executedById;
                    audit.TransactionId = transactionId;
                    audit.ExecutionTimeInMs = timer.ElapsedMilliseconds;

                    await _unitOfWork.AuditRepository.AddAsync(audit, cancellationToken);
                    await _unitOfWork.Complete();
                }
                else
                {
                    result = Result.Failure<TValue>(Error.Transaction);
                }
            }
            return result;
        }
    }
}