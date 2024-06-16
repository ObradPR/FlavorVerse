using AutoMapper;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Cuisine;
using FlavorVerse.Application.Dtos.Ingredient;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;

namespace FlavorVerse.Application.BusinessLogic.Cuisines.Queries;

public class GetCuisinesForRecipeQuery : IQuery<RecipeCuisinesDto>
{
    public Guid RecipeId { get; set; }

    public GetCuisinesForRecipeQuery(Guid recipeId) => RecipeId = recipeId;

    // Handler
    public class GetCuisinesForRecipeHandler : BaseHandler, IQueryHandler<GetCuisinesForRecipeQuery, RecipeCuisinesDto>
    {
        public GetCuisinesForRecipeHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<RecipeCuisinesDto>> Handle(GetCuisinesForRecipeQuery request, CancellationToken cancellationToken)
        {
            var recipe = await UnitOfWork.RecipeRepository.GetCuisinesForRecipeAsync(request.RecipeId, cancellationToken);

            if (recipe is null)
            {
                return Result.Failure<RecipeCuisinesDto>(Error<Recipe>.NotFound);
            }

            var recipeMapped = Mapper.Map<RecipeCuisinesDto>(recipe);

            return Result.Success(recipeMapped);
        }
    }
}