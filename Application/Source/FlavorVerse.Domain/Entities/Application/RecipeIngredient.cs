using FlavorVerse.Domain.Entities._BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlavorVerse.Domain.Entities.Application;

public class RecipeIngredient : IAuditableEntity
{
    public int IngredientId { get; set; }
    public Guid RecipeId { get; set; }
    public string Quantity { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public Guid? ModifiedBy { get; set; }
    public DateTime? DeletedAt { get; set; }
    public Guid? DeletedBy { get; set; }

    // Relationships

    [ForeignKey(nameof(IngredientId))]
    public virtual Ingredient Ingredient { get; set; }

    [ForeignKey(nameof(RecipeId))]
    public virtual Recipe Recipe { get; set; }
}