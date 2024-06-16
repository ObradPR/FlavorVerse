namespace FlavorVerse.Application.Dtos.Ingredient;

public class AddIngredientToRecipeDto : BaseDto
{
    public int Id { get; set; }
    public string Quantity { get; set; } = string.Empty;
}