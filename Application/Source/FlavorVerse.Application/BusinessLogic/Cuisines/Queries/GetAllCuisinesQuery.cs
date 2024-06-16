using AutoMapper;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Cuisine;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;

namespace FlavorVerse.Application.BusinessLogic.Cuisines.Queries;

public class GetAllCuisinesQuery : IQuery<PaginatedList<CuisineDto>>
{
    public QueryParams QueryParameters { get; set; }

    public GetAllCuisinesQuery(QueryParams queryParams) => QueryParameters = queryParams;

    // Handler
    public class GetAllCuisinesHandler : BaseHandler, IQueryHandler<GetAllCuisinesQuery, PaginatedList<CuisineDto>>
    {
        public GetAllCuisinesHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<PaginatedList<CuisineDto>>> Handle(GetAllCuisinesQuery request, CancellationToken cancellationToken)
        {
            var paginatedCuisines = await UnitOfWork.CuisineRepository.GetAllAsync(request.QueryParameters, cancellationToken);

            if (paginatedCuisines is null || paginatedCuisines.TotalCount < 1)
            {
                return Result.Failure<PaginatedList<CuisineDto>>(Error<Cuisine>.NotFound);
            }

            var cuisinesMapped = Mapper.Map<PaginatedList<CuisineDto>>(paginatedCuisines);

            return Result.Success(cuisinesMapped);
        }
    }
}