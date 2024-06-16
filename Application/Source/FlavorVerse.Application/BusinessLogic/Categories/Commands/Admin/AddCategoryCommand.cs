using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Repositories;
using FluentValidation;
using FlavorVerse.Application.Dtos.Category;
using FlavorVerse.Domain.Entities.Application;

namespace FlavorVerse.Application.BusinessLogic.Categories.Commands.Admin;

public class AddCategoryCommand : ICommand
{
    public AddCategoryDto CategoryDto { get; set; }

    public AddCategoryCommand(AddCategoryDto categoryDto) => CategoryDto = categoryDto;

    // Validators
    public class AddCuisineValidtion : AbstractValidator<AddCategoryDto>
    {
        public AddCuisineValidtion(IUnitOfWork unitOfWork)
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name property is required.")
                .MaximumLength(30)
                .WithMessage("Name can have at most 30 characters.")
                .MustAsync(async (name, cancellationToken) =>
                {
                    return !await unitOfWork.CategoryRepository.CategoryExistByNameAsync(name, cancellationToken);
                })
                .WithMessage("Category with this name already exists.");
        }
    }

    // Handler
    public class AddCategoryHandler : BaseHandler<AddCategoryDto>, ICommandHandler<AddCategoryCommand>
    {
        public AddCategoryHandler(ITransactionService transactionService, IUnitOfWork unitOfWork, IValidator<AddCategoryDto> validator) : base(transactionService, unitOfWork, validator)
        {
        }

        public async Task<Result> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await Validator.ValidateAsync(request.CategoryDto, cancellationToken);

            if (!validationResult.IsValid)
            {
                return ValidationError.FailureWithValidationResult<AddCategoryDto>(validationResult);
            }

            var transactionId = Guid.NewGuid();

            var newCategoryId = await UnitOfWork.CategoryRepository.GetNewCategoryIdAsync();

            return await TransactionService.TryProcess<int, string>(transactionId, newCategoryId, eEntityType.Category, eActionType.Insert, UserContext.CurrentUserId, async () =>
            {
                var category = new Category
                {
                    Name = request.CategoryDto.Name,
                    ParentId = request.CategoryDto.ParentId,
                    CreatedAt = DateTime.UtcNow,
                    IsActive = true
                };

                await UnitOfWork.CategoryRepository.AddAsync(category, cancellationToken);

                if (await UnitOfWork.Complete())
                {
                    return Result.Success("Successfully created category.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}