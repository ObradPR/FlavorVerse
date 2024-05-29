namespace FlavorVerse.Domain.Entities.Application;

public class DietaryInfo
{
    public int Id { get; set; }
    public bool GlutenFree { get; set; }
    public bool DairyFree { get; set; }
    public bool Vegetarian { get; set; }
    public bool Vegan { get; set; }

    // Relationships

    public virtual ICollection<Recipe> Recipes { get; set; } = new HashSet<Recipe>();
}