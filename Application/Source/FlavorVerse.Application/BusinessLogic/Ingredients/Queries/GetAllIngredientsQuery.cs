using AutoMapper;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Ingredient;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;

namespace FlavorVerse.Application.BusinessLogic.Ingredients.Queries;

public class GetAllIngredientsQuery : IQuery<PaginatedList<IngredientDto>>
{
    public QueryParams QueryParameters { get; set; }

    public GetAllIngredientsQuery(QueryParams queryParams) => QueryParameters = queryParams;

    // Handler
    public class GetAllIngredientsHandler : BaseHandler, IQueryHandler<GetAllIngredientsQuery, PaginatedList<IngredientDto>>
    {
        public GetAllIngredientsHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<PaginatedList<IngredientDto>>> Handle(GetAllIngredientsQuery request, CancellationToken cancellationToken)
        {
            var paginatedIngredients = await UnitOfWork.IngredientRepoistory.GetAllAsync(request.QueryParameters, cancellationToken);

            if (paginatedIngredients is null || paginatedIngredients.TotalCount < 1)
            {
                return Result.Failure<PaginatedList<IngredientDto>>(Error<Ingredient>.NotFound);
            }

            var ingredientsMapped = Mapper.Map<PaginatedList<IngredientDto>>(paginatedIngredients);

            return Result.Success(ingredientsMapped);
        }
    }
}