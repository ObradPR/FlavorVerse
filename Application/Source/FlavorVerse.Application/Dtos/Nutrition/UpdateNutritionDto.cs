namespace FlavorVerse.Application.Dtos.Nutrition;

public class UpdateNutritionDto : BaseDto
{
    public int? Protein { get; set; }
    public int? Carbohydrates { get; set; }
    public int? Fat { get; set; }
    public int? Fiber { get; set; }
    public bool? IsActive { get; set; }
}