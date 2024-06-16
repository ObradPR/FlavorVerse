using AutoMapper;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Recipe;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;

namespace FlavorVerse.Application.BusinessLogic.Recipes.Queries;

public class GetSingleRecipeByIdQuery : IQuery<RecipeDto>
{
    public Guid Id { get; set; }

    public GetSingleRecipeByIdQuery(Guid id) => Id = id;

    // Handler
    public class GetSingleRecipeByIdHandler : BaseHandler, IQueryHandler<GetSingleRecipeByIdQuery, RecipeDto>
    {
        public GetSingleRecipeByIdHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<RecipeDto>> Handle(GetSingleRecipeByIdQuery request, CancellationToken cancellationToken)
        {
            var recipe = await UnitOfWork.RecipeRepository.GetRecipeDetailsByIdAsync(request.Id, cancellationToken);

            if (recipe is null)
            {
                return Result.Failure<RecipeDto>(Error<Recipe>.NotFound);
            }

            var recipeMapped = Mapper.Map<RecipeDto>(recipe);

            return Result.Success(recipeMapped);
        }
    }
}