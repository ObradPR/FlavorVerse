using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Rating;
using FlavorVerse.Application.Helpers;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FluentValidation;

namespace FlavorVerse.Application.BusinessLogic.Ratings.Commands;

public class AddRatingCommand : ICommand
{
    public NewRatingDto RatingDto { get; set; }

    public AddRatingCommand(NewRatingDto ratingDto) => RatingDto = ratingDto;

    // Validators
    public class AddRatingValidtion : AbstractValidator<NewRatingDto>
    {
        public AddRatingValidtion()
        {
            RuleFor(x => x.Comment)
                .NotEmpty()
                .WithMessage("Comment property is required.")
                .MaximumLength(255)
                .WithMessage("Title can have at most 255 characters.");

            RuleFor(x => x.RatingValue)
                .NotEmpty()
                .WithMessage("Rating value is required.")
                .GreaterThan(0)
                .LessThanOrEqualTo(10)
                .WithMessage("Rating value must be in range from 1 - 10");

            RuleFor(x => x.RecipeId)
                .NotEmpty()
                .WithMessage("Recipe id is required.");
        }
    }

    // Handler
    public class AddRatingHandler : BaseHandler<NewRatingDto>, ICommandHandler<AddRatingCommand>
    {
        public AddRatingHandler(ITransactionService transactionService, IUnitOfWork unitOfWork, IValidator<NewRatingDto> validator) : base(transactionService, unitOfWork, validator)
        {
        }

        public async Task<Result> Handle(AddRatingCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await Validator.ValidateAsync(request.RatingDto, cancellationToken);

            if (!validationResult.IsValid)
            {
                return ValidationError.FailureWithValidationResult<NewRatingDto>(validationResult);
            }

            if (!await UnitOfWork.RecipeRepository.RecipeExistByIdAsync(request.RatingDto.RecipeId, cancellationToken))
            {
                return Result.Failure(Error<Recipe>.NotFound);
            }

            var transactionId = Guid.NewGuid();
            var newRatingId = Guid.NewGuid();

            return await TransactionService.TryProcess(transactionId, newRatingId, eEntityType.Rating, eActionType.Insert, UserContext.CurrentUserId, async () =>
            {
                var rating = new Rating
                {
                    Id = newRatingId,
                    UserId = UserContext.CurrentUserId,
                    RatingValue = request.RatingDto.RatingValue,
                    Comment = request.RatingDto.Comment,
                    RecipeId = request.RatingDto.RecipeId,
                    IsActive = true,
                    CreatedAt = DateTime.UtcNow
                };

                await UnitOfWork.RatingRepository.AddAsync(rating, cancellationToken);

                if (await UnitOfWork.Complete())
                {
                    return Result.Success("Successfully created rating.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}