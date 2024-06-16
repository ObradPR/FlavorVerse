using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FlavorVerse.Common;

namespace FlavorVerse.Application.BusinessLogic.Nutritions.Commands;

public class DeleteNutritionCommand : ICommand
{
    public Guid Id { get; set; }

    public DeleteNutritionCommand(Guid id) => Id = id;

    // Handler
    public class DeleteNutritionHandler : BaseHandler, ICommandHandler<DeleteNutritionCommand>
    {
        public DeleteNutritionHandler(ITransactionService transactionService, IUnitOfWork unitOfWork) : base(transactionService, unitOfWork)
        {
        }

        public async Task<Result> Handle(DeleteNutritionCommand request, CancellationToken cancellationToken)
        {
            var adminRole = UserContext.CurrentRoles.Find(x => x.Equals(Constants.ADMIN));

            var nutrition = await UnitOfWork.NutritionRepository.GetNutritionByIdAsync(request.Id, cancellationToken);

            if (nutrition is null)
            {
                return Result.Failure(Error<Nutrition>.NotFound);
            }

            if (string.IsNullOrEmpty(adminRole) && nutrition.Recipes.First().UserId != UserContext.CurrentUserId)
            {
                return Result.Failure(Error.ActionForbidden);
            }

            var transactionId = Guid.NewGuid();

            return await TransactionService.TryProcess(transactionId, nutrition.Id, eEntityType.Nutrition, eActionType.Delete, UserContext.CurrentUserId, async () =>
            {
                if (!nutrition.IsActive)
                {
                    return Result.Success("Recipe is already deleted.");
                }

                nutrition.IsActive = false;
                nutrition.DeletedAt = DateTime.UtcNow;
                nutrition.DeletedBy = UserContext.CurrentUserId;

                if (await UnitOfWork.Complete())
                {
                    return Result.Success("Successfully deleted.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}