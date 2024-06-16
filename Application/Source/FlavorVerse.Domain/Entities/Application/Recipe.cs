using FlavorVerse.Domain.Entities._BaseEntities;
using FlavorVerse.Domain.Entities.Application_lu;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlavorVerse.Domain.Entities.Application;

public class Recipe : Entity
{
    public string Title { get; set; } = string.Empty;
    public Guid UserId { get; set; }
    public string Image { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string CookingTime { get; set; } = string.Empty;
    public int Servings { get; set; }
    public int DifficultyId { get; set; }
    public int DietaryInfoId { get; set; }
    public Guid NutritionId { get; set; }
    public bool Featured { get; set; } = false;
    public string Instructions { get; set; } = string.Empty;
    public int MealTypeId { get; set; }

    // Relationships

    [ForeignKey(nameof(UserId))]
    public virtual User User { get; set; }

    [ForeignKey(nameof(DifficultyId))]
    public virtual DifficultyCooking_lu DifficultyCooking_Lu { get; set; }

    [ForeignKey(nameof(DietaryInfoId))]
    public virtual DietaryInfo DietaryInfo { get; set; }

    [ForeignKey(nameof(NutritionId))]
    public virtual Nutrition Nutrition { get; set; }

    [ForeignKey(nameof(MealTypeId))]
    public virtual MealType_lu MealType_Lu { get; set; }

    public virtual ICollection<Rating> Ratings { get; set; } = new HashSet<Rating>();
    public virtual ICollection<RecipeCuisine> RecipeCuisines { get; set; } = new HashSet<RecipeCuisine>();
    public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new HashSet<RecipeIngredient>();
    public virtual ICollection<RecipeCategory> RecipeCategories { get; set; } = new HashSet<RecipeCategory>();
}