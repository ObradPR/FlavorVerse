namespace FlavorVerse.Application.Dtos.Recipe;

public class DietaryInfoDto : BaseDto
{
    public int Id { get; set; }
    public bool GlutenFree { get; set; }
    public bool DairyFree { get; set; }
    public bool Vegetarian { get; set; }
    public bool Vegan { get; set; }
}