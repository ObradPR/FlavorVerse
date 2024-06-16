using FlavorVerse.Domain.Entities._BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlavorVerse.Domain.Entities.Application;

public class Category : Entity_lu, IAuditableEntity
{
    public int? ParentId { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public Guid? ModifiedBy { get; set; }
    public DateTime? DeletedAt { get; set; }
    public Guid? DeletedBy { get; set; }

    // Relationships

    [ForeignKey(nameof(ParentId))]
    public virtual Category Parent { get; set; }

    public virtual ICollection<Category> ChildCategories { get; set; } = new HashSet<Category>();
    public virtual ICollection<RecipeCategory> RecipeCategories { get; set; } = new HashSet<RecipeCategory>();
}