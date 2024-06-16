using AutoMapper;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Recipe;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;

namespace FlavorVerse.Application.BusinessLogic.Recipes.Queries;

public class GetAllRecipesQuery : IQuery<PaginatedList<RecipeDto>>
{
    public QueryParams QueryParameters { get; set; }

    public GetAllRecipesQuery(QueryParams queryParams) => QueryParameters = queryParams;

    // Handler
    public class GetAllRecipesHandler : BaseHandler, IQueryHandler<GetAllRecipesQuery, PaginatedList<RecipeDto>>
    {
        public GetAllRecipesHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<PaginatedList<RecipeDto>>> Handle(GetAllRecipesQuery request, CancellationToken cancellationToken)
        {
            var paginatedRecipes = await UnitOfWork.RecipeRepository.GetAllAsync(request.QueryParameters, cancellationToken);

            if (paginatedRecipes is null || paginatedRecipes.TotalCount < 1)
            {
                return Result.Failure<PaginatedList<RecipeDto>>(Error<Recipe>.NotFound);
            }

            var recipesMapped = Mapper.Map<PaginatedList<RecipeDto>>(paginatedRecipes);

            return Result.Success(recipesMapped);
        }
    }
}