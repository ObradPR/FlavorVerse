using Microsoft.AspNetCore.Http;

namespace FlavorVerse.Application.Dtos.Recipe;

public class UpdateRecipeDto : BaseDto
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public IFormFile? Image { get; set; }
    public string? CookingTime { get; set; }
    public int? Servings { get; set; }
    public string? Instructions { get; set; }
    public int? MealTypeId { get; set; }
    public bool? GlutenFree { get; set; }
    public bool? DairyFree { get; set; }
    public bool? Vegetarian { get; set; }
    public bool? Vegan { get; set; }
    public int? DifficultyCookingId { get; set; }
    public bool? IsActive { get; set; }
}