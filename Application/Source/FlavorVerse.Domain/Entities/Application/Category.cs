using FlavorVerse.Domain.Entities._BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlavorVerse.Domain.Entities.Application;

public class Category : Entity_lu
{
    public int? ParentId { get; set; }

    // Relationships

    [ForeignKey(nameof(ParentId))]
    public virtual Category Parent { get; set; }

    public virtual ICollection<Category> ChildCategories { get; set; } = new HashSet<Category>();
    public virtual ICollection<RecipeCategory> RecipeCategories { get; set; } = new HashSet<RecipeCategory>();
}