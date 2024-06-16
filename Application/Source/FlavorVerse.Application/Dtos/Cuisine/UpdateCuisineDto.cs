namespace FlavorVerse.Application.Dtos.Cuisine;

public class UpdateCuisineDto : BaseDto
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
    public bool? IsActive { get; set; }
}