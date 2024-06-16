namespace FlavorVerse.Application.Dtos.Category;

public class DeleteIngredientForRecipeDto : BaseDto
{
    public Guid RecipeId { get; set; }
    public int IngredientId { get; set; }
}