using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;

namespace FlavorVerse.Application.BusinessLogic.Ingredients.Commands.Admin;

public class DeleteIngredientCommand : ICommand
{
    public int Id { get; set; }

    public DeleteIngredientCommand(int id) => Id = id;

    // Handler
    public class DeleteIngredientHandler : BaseHandler, ICommandHandler<DeleteIngredientCommand>
    {
        public DeleteIngredientHandler(ITransactionService transactionService, IUnitOfWork unitOfWork) : base(transactionService, unitOfWork)
        {
        }

        public async Task<Result> Handle(DeleteIngredientCommand request, CancellationToken cancellationToken)
        {
            var ingredient = await UnitOfWork.IngredientRepoistory.GetIngredientByIdAsync(request.Id, cancellationToken);

            if (ingredient is null)
            {
                return Result.Failure(Error<Ingredient>.NotFound);
            }

            var transactionId = Guid.NewGuid();

            return await TransactionService.TryProcess(transactionId, ingredient.Id, eEntityType.Ingredient, eActionType.Delete, UserContext.CurrentUserId, async () =>
            {
                if (!ingredient.IsActive)
                {
                    return Result.Success("Ingredient is already deleted.");
                }

                ingredient.IsActive = false;
                ingredient.ModifiedAt = DateTime.UtcNow;
                ingredient.ModifiedBy = UserContext.CurrentUserId;
                ingredient.DeletedAt = DateTime.UtcNow;
                ingredient.DeletedBy = UserContext.CurrentUserId;

                if (await UnitOfWork.Complete())
                {
                    return Result.Success("Successfully deleted.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}