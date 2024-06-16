namespace FlavorVerse.Application.Dtos.Ingredient;

public class UpdateIngredientDto : BaseDto
{
    public string? Name { get; set; }
    public bool? IsActive { get; set; }
}