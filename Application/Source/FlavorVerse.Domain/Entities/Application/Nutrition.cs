using FlavorVerse.Domain.Entities._BaseEntities;

namespace FlavorVerse.Domain.Entities.Application;

public class Nutrition : Entity
{
    public int? Calories { get; set; }
    public int? Protein { get; set; }
    public int? Carbohydrates { get; set; }
    public int? Fat { get; set; }
    public int? Fiber { get; set; }

    // Relationships
    public virtual ICollection<Recipe> Recipes { get; set; } = new HashSet<Recipe>();
}