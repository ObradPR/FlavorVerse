using FlavorVerse.Domain.Entities._BaseEntities;

namespace FlavorVerse.Domain.Entities.Application;

public class Ingredient : Entity_lu
{
    // Relationships

    public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new HashSet<RecipeIngredient>();
}