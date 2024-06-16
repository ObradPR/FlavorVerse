namespace FlavorVerse.Application.Dtos.Ingredient;

public class IngredientDto : BaseDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Quantity { get; set; } = string.Empty;
}