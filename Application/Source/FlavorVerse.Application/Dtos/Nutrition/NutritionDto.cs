namespace FlavorVerse.Application.Dtos.Nutrition;

public class NutritionDto : BaseDto
{
    public Guid Id { get; set; }
    public int Calories { get; set; }
    public int Protein { get; set; }
    public int Carbohydrates { get; set; }
    public int Fat { get; set; }
    public int Fiber { get; set; }
}