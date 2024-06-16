using AutoMapper;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Rating;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;

namespace FlavorVerse.Application.BusinessLogic.Ratings.Queries.Admin;

public class GetAllRatingsQuery : IQuery<PaginatedList<AdminRatingDto>>
{
    public QueryParams QueryParameters { get; set; }

    public GetAllRatingsQuery(QueryParams queryParams) => QueryParameters = queryParams;

    // Handler
    public class GetAllRatingsHandler : BaseHandler, IQueryHandler<GetAllRatingsQuery, PaginatedList<AdminRatingDto>>
    {
        public GetAllRatingsHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<PaginatedList<AdminRatingDto>>> Handle(GetAllRatingsQuery request, CancellationToken cancellationToken)
        {
            var paginatedRatings = await UnitOfWork.RatingRepository.GetAllAsync(request.QueryParameters, cancellationToken);

            if (paginatedRatings is null || paginatedRatings.TotalCount < 1)
            {
                return Result.Failure<PaginatedList<AdminRatingDto>>(Error<Rating>.NotFound);
            }

            var ratingsMapped = Mapper.Map<PaginatedList<AdminRatingDto>>(paginatedRatings);

            return Result.Success(ratingsMapped);
        }
    }
}