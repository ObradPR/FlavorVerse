namespace FlavorVerse.Application.Dtos.Ingredient;

public class AddIngredientsToRecipeDto : BaseDto
{
    public Guid RecipeId { get; set; }
    public List<AddIngredientToRecipeDto> Ingredients { get; set; } = [];
}