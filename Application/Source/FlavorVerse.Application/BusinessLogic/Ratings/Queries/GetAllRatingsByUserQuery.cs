using AutoMapper;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Rating;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;

namespace FlavorVerse.Application.BusinessLogic.Ratings.Queries;

public class GetAllRatingsByUserQuery : IQuery<PaginatedList<UserRatingDto>>
{
    public QueryParams QueryParameters { get; set; }
    public Guid Id { get; set; }

    public GetAllRatingsByUserQuery(Guid id, QueryParams queryParams)
    {
        Id = id;
        QueryParameters = queryParams;
    }

    // Handler
    public class GetAllRatingsHandler : BaseHandler, IQueryHandler<GetAllRatingsByUserQuery, PaginatedList<UserRatingDto>>
    {
        public GetAllRatingsHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<PaginatedList<UserRatingDto>>> Handle(GetAllRatingsByUserQuery request, CancellationToken cancellationToken)
        {
            var paginatedRatings = await UnitOfWork.RatingRepository.GetAllByUserIdAsync(request.Id, request.QueryParameters, cancellationToken);

            if (paginatedRatings is null || paginatedRatings.TotalCount < 1)
            {
                return Result.Failure<PaginatedList<UserRatingDto>>(Error<Rating>.NotFound);
            }

            var ratingsMapped = Mapper.Map<PaginatedList<UserRatingDto>>(paginatedRatings);

            return Result.Success(ratingsMapped);
        }
    }
}