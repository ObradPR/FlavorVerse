namespace FlavorVerse.Application.Dtos.Cuisine;

public class RecipeCuisinesDto : BaseDto
{
    public Guid RecipeId { get; set; }
    public string RecipeTitle { get; set; } = string.Empty;
    public List<CuisineDto> Cuisines { get; set; } = [];
}