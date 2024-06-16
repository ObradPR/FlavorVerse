namespace FlavorVerse.Application.Dtos.Category;

public class AddCategoriesToRecipeDto : BaseDto
{
    public Guid RecipeId { get; set; }
    public List<int> Categories { get; set; } = [];
}