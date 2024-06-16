using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Category;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FluentValidation;

namespace FlavorVerse.Application.BusinessLogic.Categories.Commands.Admin;

public class UpdateCategoryCommand : ICommand
{
    public int Id { get; set; }
    public UpdateCategoryDto Category { get; set; }

    public UpdateCategoryCommand(int id, UpdateCategoryDto category)
    {
        Id = id;
        Category = category;
    }

    // Validators
    public class UpdateCategoryValidation : AbstractValidator<UpdateCategoryDto>
    {
        public UpdateCategoryValidation(IUnitOfWork unitOfWork)
        {
            RuleFor(x => x.Name)
                .MaximumLength(30)
                .WithMessage("Category name must be at most 30 characters long.")
                .MustAsync(async (name, cancellationToken) =>
                {
                    return !await unitOfWork.CategoryRepository.CategoryExistByNameAsync(name, cancellationToken);
                })
                .WithMessage("Category with this name already exist. Or if you included same name for update jsut set it to null in request.");
        }
    }

    // Handlers
    public class UpdateCategoryHandler : BaseHandler<UpdateCategoryDto>, ICommandHandler<UpdateCategoryCommand>
    {
        public UpdateCategoryHandler(ITransactionService transactionService, IUnitOfWork unitOfWork, IValidator<UpdateCategoryDto> validator) : base(transactionService, unitOfWork, validator)
        {
        }

        public async Task<Result> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await UnitOfWork.CategoryRepository.GetCategoryByIdAsync(request.Id, cancellationToken);

            if (category is null)
            {
                return Result.Failure(Error<Category>.NotFound);
            }

            if (string.IsNullOrEmpty(request.Category.Name)
                && request.Category.ParentId is null
                && request.Category.IsActive is null)
            {
                return Result.Failure(Error.NullValue);
            }

            var validationResult = await Validator.ValidateAsync(request.Category, cancellationToken);

            if (!validationResult.IsValid)
            {
                return ValidationError.FailureWithValidationResult<UpdateCategoryDto>(validationResult);
            }

            var transactionId = Guid.NewGuid();

            return await TransactionService.TryProcess<int, string>(transactionId, request.Id, eEntityType.Category, eActionType.Update, UserContext.CurrentUserId, async () =>
            {
                category.Name = request.Category.Name ?? category.Name;
                category.ParentId = request.Category.ParentId;
                category.IsActive = request.Category.IsActive ?? category.IsActive;
                category.ModifiedAt = DateTime.UtcNow;
                category.ModifiedBy = UserContext.CurrentUserId;

                if (request.Category.IsActive == false)
                {
                    category.DeletedAt = DateTime.UtcNow;
                    category.DeletedBy = UserContext.CurrentUserId;
                }

                if (await UnitOfWork.Complete())
                {
                    return Result.Success<string>("Successfully updated category.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}