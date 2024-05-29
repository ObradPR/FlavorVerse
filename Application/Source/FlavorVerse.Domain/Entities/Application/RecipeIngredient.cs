using System.ComponentModel.DataAnnotations.Schema;

namespace FlavorVerse.Domain.Entities.Application;

public class RecipeIngredient
{
    public int IngredientId { get; set; }
    public Guid RecipeId { get; set; }
    public string Quantity { get; set; } = string.Empty;

    // Relationships

    [ForeignKey(nameof(IngredientId))]
    public virtual Ingredient Ingredient { get; set; }

    [ForeignKey(nameof(RecipeId))]
    public virtual Recipe Recipe { get; set; }
}