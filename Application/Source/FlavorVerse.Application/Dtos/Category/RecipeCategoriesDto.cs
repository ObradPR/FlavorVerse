namespace FlavorVerse.Application.Dtos.Category;

public class RecipeCategoriesDto : BaseDto
{
    public Guid RecipeId { get; set; }
    public string RecipeTitle { get; set; } = string.Empty;
    public List<CategoryDto> Categories { get; set; } = [];
}