namespace FlavorVerse.Application.Dtos.Cuisine;

public class DeleteCuisineForRecipeDto : BaseDto
{
    public Guid RecipeId { get; set; }
    public int CuisineId { get; set; }
}