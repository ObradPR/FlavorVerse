using AutoMapper;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Category;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;

namespace FlavorVerse.Application.BusinessLogic.Categories.Queries;

public class GetAllCategoriesQuery : IQuery<PaginatedList<CategoryDto>>
{
    public QueryParams QueryParameters { get; set; }

    public GetAllCategoriesQuery(QueryParams queryParams) => QueryParameters = queryParams;

    // Handler
    public class GetAllCategoriesHandler : BaseHandler, IQueryHandler<GetAllCategoriesQuery, PaginatedList<CategoryDto>>
    {
        public GetAllCategoriesHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<PaginatedList<CategoryDto>>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            var paginatedCategories = await UnitOfWork.CategoryRepository.GetAllAsync(request.QueryParameters, cancellationToken);

            if (paginatedCategories is null || paginatedCategories.TotalCount < 1)
            {
                return Result.Failure<PaginatedList<CategoryDto>>(Error<Category>.NotFound);
            }

            var categoriesMapped = Mapper.Map<PaginatedList<CategoryDto>>(paginatedCategories);

            return Result.Success(categoriesMapped);
        }
    }
}