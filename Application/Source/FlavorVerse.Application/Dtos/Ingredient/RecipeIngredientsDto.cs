using FlavorVerse.Application.Dtos.Cuisine;

namespace FlavorVerse.Application.Dtos.Ingredient;

public class RecipeIngredientsDto : BaseDto
{
    public Guid RecipeId { get; set; }
    public string RecipeTitle { get; set; } = string.Empty;
    public List<IngredientDto> Ingredients { get; set; } = [];
}