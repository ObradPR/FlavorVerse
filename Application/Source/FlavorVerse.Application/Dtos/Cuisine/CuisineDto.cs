namespace FlavorVerse.Application.Dtos.Cuisine;

public class CuisineDto : BaseDto
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
}