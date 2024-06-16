using AutoMapper;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Cuisine;
using FlavorVerse.Application.Dtos.Ingredient;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;

namespace FlavorVerse.Application.BusinessLogic.Ingredients.Queries;

public class GetIngredientsForRecipeQuery : IQuery<RecipeIngredientsDto>
{
    public Guid RecipeId { get; set; }

    public GetIngredientsForRecipeQuery(Guid recipeId) => RecipeId = recipeId;

    // Handler
    public class GetIngredientsForRecipeHandler : BaseHandler, IQueryHandler<GetIngredientsForRecipeQuery, RecipeIngredientsDto>
    {
        public GetIngredientsForRecipeHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<RecipeIngredientsDto>> Handle(GetIngredientsForRecipeQuery request, CancellationToken cancellationToken)
        {
            var recipe = await UnitOfWork.RecipeRepository.GetIngredientsForRecipeAsync(request.RecipeId, cancellationToken);

            if (recipe is null)
            {
                return Result.Failure<RecipeIngredientsDto>(Error<Recipe>.NotFound);
            }

            var recipeMapped = Mapper.Map<RecipeIngredientsDto>(recipe);

            return Result.Success(recipeMapped);
        }
    }
}