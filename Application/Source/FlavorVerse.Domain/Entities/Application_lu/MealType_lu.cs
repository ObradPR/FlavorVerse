using FlavorVerse.Domain.Entities._BaseEntities;
using FlavorVerse.Domain.Entities.Application;

namespace FlavorVerse.Domain.Entities.Application_lu
{
    public class MealType_lu : Entity_lu
    {
        // Relationships

        public virtual ICollection<Recipe> Recipes { get; set; } = new HashSet<Recipe>();
    }
}