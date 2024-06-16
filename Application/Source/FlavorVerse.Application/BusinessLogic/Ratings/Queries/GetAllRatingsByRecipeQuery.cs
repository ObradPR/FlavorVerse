using AutoMapper;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Rating;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;

namespace FlavorVerse.Application.BusinessLogic.Ratings.Queries;

public class GetAllRatingsByRecipeQuery : IQuery<PaginatedList<UserRatingDto>>
{
    public QueryParams QueryParameters { get; set; }
    public Guid Id { get; set; }

    public GetAllRatingsByRecipeQuery(Guid id, QueryParams queryParams)
    {
        Id = id;
        QueryParameters = queryParams;
    }

    // Handler
    public class GetAllRatingsHandler : BaseHandler, IQueryHandler<GetAllRatingsByRecipeQuery, PaginatedList<UserRatingDto>>
    {
        public GetAllRatingsHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<PaginatedList<UserRatingDto>>> Handle(GetAllRatingsByRecipeQuery request, CancellationToken cancellationToken)
        {
            var paginatedRatings = await UnitOfWork.RatingRepository.GetAllByRecipeIdAsync(request.Id, request.QueryParameters, cancellationToken);

            if (paginatedRatings is null || paginatedRatings.TotalCount < 1)
            {
                return Result.Failure<PaginatedList<UserRatingDto>>(Error<Rating>.NotFound);
            }

            var ratingsMapped = Mapper.Map<PaginatedList<UserRatingDto>>(paginatedRatings);

            return Result.Success(ratingsMapped);
        }
    }
}