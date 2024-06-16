using FlavorVerse.Application.Abstractions;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.BusinessLogic.Ingredients.Commands;
using FlavorVerse.Application.Dtos.Ingredient;
using FlavorVerse.Application.Dtos.Rating;
using FlavorVerse.Application.Identity.Extensions;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common;
using FlavorVerse.Common.Enums;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;
using FluentValidation;

namespace FlavorVerse.Application.BusinessLogic.Ratings.Commands;

public class UpdateRatingCommand : ICommand
{
    public Guid Id { get; set; }
    public UpdateRatingDto RatingDto { get; set; }

    public UpdateRatingCommand(Guid id, UpdateRatingDto rating)
    {
        Id = id;
        RatingDto = rating;
    }

    // Validators
    public class UpdateRatingValidation : AbstractValidator<UpdateRatingDto>
    {
        public UpdateRatingValidation()
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
        }
    }

    // Handlers
    public class UpdateRatingHandler : BaseHandler<UpdateRatingDto>, ICommandHandler<UpdateRatingCommand>
    {
        public UpdateRatingHandler(ITransactionService transactionService, IUnitOfWork unitOfWork, IValidator<UpdateRatingDto> validator) : base(transactionService, unitOfWork, validator)
        {
        }

        public async Task<Result> Handle(UpdateRatingCommand request, CancellationToken cancellationToken)
        {
            var adminRole = UserContext.CurrentRoles.Find(x => x.Equals(Constants.ADMIN));

            var rating = await UnitOfWork.RatingRepository.GetRatingByIdAsync(request.Id, cancellationToken);

            if (rating is null)
            {
                return Result.Failure(Error<Rating>.NotFound);
            }

            if (string.IsNullOrEmpty(adminRole) && rating.UserId != UserContext.CurrentUserId)
            {
                return Result.Failure(Error.ActionForbidden);
            }

            if (string.IsNullOrEmpty(request.RatingDto.Comment)
                && request.RatingDto.RatingValue is null)
            {
                return Result.Failure(Error.NullValue);
            }

            if (!string.IsNullOrEmpty(request.RatingDto.Comment)
                && request.RatingDto.RatingValue is null)
            {
                var newRatingDto = new UpdateRatingDto
                {
                    Comment = request.RatingDto.Comment,
                    RatingValue = rating.RatingValue
                };

                var validationResult = await Validator.ValidateAsync(newRatingDto, cancellationToken);

                if (!validationResult.IsValid)
                {
                    return ValidationError.FailureWithValidationResult<UpdateRatingDto>(validationResult);
                }
            }
            else if (string.IsNullOrEmpty(request.RatingDto.Comment)
                && request.RatingDto.RatingValue is not null)
            {
                var newRatingDto = new UpdateRatingDto
                {
                    Comment = rating.Comment,
                    RatingValue = request.RatingDto.RatingValue
                };

                var validationResult = await Validator.ValidateAsync(newRatingDto, cancellationToken);

                if (!validationResult.IsValid)
                {
                    return ValidationError.FailureWithValidationResult<UpdateRatingDto>(validationResult);
                }
            }
            else
            {
                var validationResult = await Validator.ValidateAsync(request.RatingDto, cancellationToken);

                if (!validationResult.IsValid)
                {
                    return ValidationError.FailureWithValidationResult<UpdateRatingDto>(validationResult);
                }
            }

            var transactionId = Guid.NewGuid();

            return await TransactionService.TryProcess(transactionId, request.Id, eEntityType.Rating, eActionType.Update, UserContext.CurrentUserId, async () =>
            {
                if (request.RatingDto.IsActive == false)
                {
                    rating.DeletedAt = DateTime.UtcNow;
                    rating.DeletedBy = UserContext.CurrentUserId;
                    rating.IsActive = false;
                }
                else if (request.RatingDto.IsActive == true)
                {
                    rating.IsActive = true;
                }

                rating.Comment = request.RatingDto.Comment ?? rating.Comment;
                rating.RatingValue = request.RatingDto.RatingValue ?? rating.RatingValue;
                rating.ModifiedAt = DateTime.UtcNow;
                rating.ModifiedBy = UserContext.CurrentUserId;

                if (await UnitOfWork.Complete())
                {
                    return Result.Success("Successfully updated rating.");
                }

                return Result.Failure<string>(Error.SaveChangesFailed);
            }, cancellationToken);
        }
    }
}