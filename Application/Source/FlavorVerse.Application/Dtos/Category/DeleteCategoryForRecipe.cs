namespace FlavorVerse.Application.Dtos.Category;

public class DeleteCategoryForRecipeDto : BaseDto
{
    public Guid RecipeId { get; set; }
    public int CategoryId { get; set; }
}