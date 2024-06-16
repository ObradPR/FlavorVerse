namespace FlavorVerse.Application.Dtos.Category;

public class AddCategoryDto : BaseDto
{
    public string Name { get; set; } = string.Empty;
    public int? ParentId { get; set; }
}