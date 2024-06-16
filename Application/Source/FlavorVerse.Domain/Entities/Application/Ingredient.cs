using FlavorVerse.Domain.Entities._BaseEntities;

namespace FlavorVerse.Domain.Entities.Application;

public class Ingredient : Entity_lu, IAuditableEntity
{
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public Guid? ModifiedBy { get; set; }
    public DateTime? DeletedAt { get; set; }
    public Guid? DeletedBy { get; set; }

    // Relationships

    public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new HashSet<RecipeIngredient>();
}