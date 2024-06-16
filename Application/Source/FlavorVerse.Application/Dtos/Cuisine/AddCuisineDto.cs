namespace FlavorVerse.Application.Dtos.Cuisine;

public class AddCuisineDto : BaseDto
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
}