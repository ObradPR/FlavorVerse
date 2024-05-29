using FlavorVerse.Domain.Entities._BaseEntities;

namespace FlavorVerse.Domain.Entities.Application;

public class Cuisine : Entity_lu
{
    public string Description { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;

    // Relationships

    public virtual ICollection<RecipeCuisine> RecipeCusines { get; set; } = new HashSet<RecipeCuisine>();
}