using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using System.Reflection.Metadata;
using FlavorVerse.Common;

namespace FlavorVerse.Application.BusinessLogic.Recipes.Commands;

public class DeleteRecipeCommand : ICommand
{
    public Guid Id { get; set; }

    public DeleteRecipeCommand(Guid id) => Id = id;

    // Handler
    public class DeleteRecipeHandler : BaseHandler, ICommandHandler<DeleteRecipeCommand>
    {
        public DeleteRecipeHandler(ITransactionService transactionService, IUnitOfWork unitOfWork) : base(transactionService, unitOfWork)
        {
        }

        public async Task<Result> Handle(DeleteRecipeCommand request, CancellationToken cancellationToken)
        {
            var adminRole = UserContext.CurrentRoles.Find(x => x.Equals(Constants.ADMIN));

            var recipe = await UnitOfWork.RecipeRepository.GetRecipeByIdAsync(request.Id, cancellationToken);

            if (recipe is null)
            {
                return Result.Failure(Error<Recipe>.NotFound);
            }

            if (string.IsNullOrEmpty(adminRole) && recipe.UserId != UserContext.CurrentUserId)
            {
                return Result.Failure(Error.ActionForbidden);
            }

            var transactionId = Guid.NewGuid();

            return await TransactionService.TryProcess(transactionId, recipe.Id, eEntityType.Recipe, eActionType.Delete, UserContext.CurrentUserId, async () =>
            {
                if (!recipe.IsActive)
                {
                    return Result.Success("Recipe is already deleted.");
                }

                recipe.IsActive = false;
                recipe.DeletedAt = DateTime.UtcNow;
                recipe.DeletedBy = UserContext.CurrentUserId;

                if (await UnitOfWork.Complete())
                {
                    return Result.Success("Successfully deleted.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}