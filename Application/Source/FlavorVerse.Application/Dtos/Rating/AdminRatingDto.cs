using FlavorVerse.Application.Dtos.User;

namespace FlavorVerse.Application.Dtos.Rating;

public class AdminRatingDto : BaseDto
{
    public Guid Id { get; set; }
    public bool IsActive { get; set; }
    public int RatingValue { get; set; }
    public string Comment { get; set; } = string.Empty;
    public Guid RecipeId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public Guid? ModifiedBy { get; set; }
    public DateTime? DeletedAt { get; set; }
    public Guid? DeletedBy { get; set; }
    public UserDto User { get; set; }
}