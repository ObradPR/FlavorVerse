namespace FlavorVerse.Application.Dtos.Cuisine;

public class AddCuisinesToRecipeDto : BaseDto
{
    public Guid RecipeId { get; set; }
    public List<int> Cuisines { get; set; } = [];
}