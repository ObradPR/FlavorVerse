using System.ComponentModel.DataAnnotations.Schema;

namespace FlavorVerse.Domain.Entities.Application;

public class RecipeCategory
{
    public int CategoryId { get; set; }
    public Guid RecipeId { get; set; }

    // Relationships

    [ForeignKey(nameof(CategoryId))]
    public virtual Category Category { get; set; }

    [ForeignKey(nameof(RecipeId))]
    public virtual Recipe Recipe { get; set; }
}