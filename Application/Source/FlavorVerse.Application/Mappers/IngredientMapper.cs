using FlavorVerse.Application.Dtos.Ingredient;
using FlavorVerse.Application.Mappers._BaseAutoMapper;
using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;

namespace FlavorVerse.Application.Mappers;

public class IngredientMapper : BaseAutoMapperProfile
{
    public IngredientMapper()
    {
        CreateMap<Ingredient, IngredientDto>();

        CreateMap<PaginatedList<Ingredient>, PaginatedList<IngredientDto>>();

        CreateMap<Recipe, RecipeIngredientsDto>()
            .ForMember(dest => dest.RecipeId, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.RecipeTitle, opt => opt.MapFrom(src => src.Title))
            .ForMember(dest => dest.Ingredients, opt => opt.MapFrom(src => src.RecipeIngredients.Select(x => new IngredientDto
            {
                Id = x.Ingredient.Id,
                Name = x.Ingredient.Name,
                Quantity = x.Quantity,
            }).ToList()));
    }
}