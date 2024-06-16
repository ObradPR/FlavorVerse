using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FluentValidation;

namespace FlavorVerse.Application.BusinessLogic.Categories.Commands.Admin;

public class DeleteCategoryCommand : ICommand
{
    public int Id { get; set; }

    public DeleteCategoryCommand(int id) => Id = id;

    // Handler
    public class DeleteCategoryHandler : BaseHandler, ICommandHandler<DeleteCategoryCommand>
    {
        public DeleteCategoryHandler(ITransactionService transactionService, IUnitOfWork unitOfWork) : base(transactionService, unitOfWork)
        {
        }

        public async Task<Result> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await UnitOfWork.CategoryRepository.GetCategoryByIdAsync(request.Id, cancellationToken);

            if (category is null)
            {
                return Result.Failure(Error<Category>.NotFound);
            }

            var transactionId = Guid.NewGuid();

            return await TransactionService.TryProcess<int, string>(transactionId, category.Id, eEntityType.Category, eActionType.Delete, UserContext.CurrentUserId, async () =>
            {
                if (!category.IsActive)
                {
                    return Result.Success("Category is already deleted.");
                }

                category.IsActive = false;
                category.ModifiedAt = DateTime.UtcNow;
                category.ModifiedBy = UserContext.CurrentUserId;
                category.DeletedAt = DateTime.UtcNow;
                category.DeletedBy = UserContext.CurrentUserId;

                if (await UnitOfWork.Complete())
                {
                    return Result.Success<string>("Successfully deleted.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}