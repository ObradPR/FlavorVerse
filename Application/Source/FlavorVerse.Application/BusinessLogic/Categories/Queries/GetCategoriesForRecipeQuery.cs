using AutoMapper;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Category;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;

namespace FlavorVerse.Application.BusinessLogic.Categories.Queries;

public class GetCategoriesForRecipeQuery : IQuery<RecipeCategoriesDto>
{
    public Guid RecipeId { get; set; }

    public GetCategoriesForRecipeQuery(Guid recipeId) => RecipeId = recipeId;

    // Handler
    public class GetCategoriesForRecipeHandler : BaseHandler, IQueryHandler<GetCategoriesForRecipeQuery, RecipeCategoriesDto>
    {
        public GetCategoriesForRecipeHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<RecipeCategoriesDto>> Handle(GetCategoriesForRecipeQuery request, CancellationToken cancellationToken)
        {
            var recipe = await UnitOfWork.RecipeRepository.GetCategoriesForRecipeAsync(request.RecipeId, cancellationToken);

            if (recipe is null)
            {
                return Result.Failure<RecipeCategoriesDto>(Error<Recipe>.NotFound);
            }

            var recipeMapped = Mapper.Map<RecipeCategoriesDto>(recipe);

            return Result.Success(recipeMapped);
        }
    }
}