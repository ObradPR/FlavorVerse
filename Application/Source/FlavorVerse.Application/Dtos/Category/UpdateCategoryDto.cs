namespace FlavorVerse.Application.Dtos.Category;

public class UpdateCategoryDto : BaseDto
{
    public string? Name { get; set; }
    public int? ParentId { get; set; }
    public bool? IsActive { get; set; }
}