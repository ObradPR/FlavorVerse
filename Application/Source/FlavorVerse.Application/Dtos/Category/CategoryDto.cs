namespace FlavorVerse.Application.Dtos.Category;

public class CategoryDto : BaseDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int? ParentId { get; set; }
}