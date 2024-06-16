namespace FlavorVerse.Application.Dtos.Ingredient;

public class EditRecipeIngredientDto : BaseDto
{
    public string? Quantity { get; set; }
    public bool? IsActive { get; set; }
}