using FlavorVerse.Domain.Entities._BaseEntities;

namespace FlavorVerse.Domain.Entities.Application;

public class Cuisine : Entity_lu, IAuditableEntity
{
    public string Description { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public Guid? ModifiedBy { get; set; }
    public DateTime? DeletedAt { get; set; }
    public Guid? DeletedBy { get; set; }

    // Relationships

    public virtual ICollection<RecipeCuisine> RecipeCuisines { get; set; } = new HashSet<RecipeCuisine>();
}