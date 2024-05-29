using System.ComponentModel.DataAnnotations.Schema;

namespace FlavorVerse.Domain.Entities.Application;

public class RecipeCuisine
{
    public int CuisineId { get; set; }
    public Guid RecipeId { get; set; }

    // Relationships

    [ForeignKey(nameof(CuisineId))]
    public virtual Cuisine Cuisine { get; set; }

    [ForeignKey(nameof(RecipeId))]
    public virtual Recipe Recipe { get; set; }
}