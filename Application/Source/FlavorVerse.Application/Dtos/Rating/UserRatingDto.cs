using FlavorVerse.Application.Dtos.User;

namespace FlavorVerse.Application.Dtos.Rating;

public class UserRatingDto : BaseDto
{
    public Guid Id { get; set; }
    public int RatingValue { get; set; }
    public string Comment { get; set; } = string.Empty;
    public Guid RecipeId { get; set; }
    public DateTime CreatedAt { get; set; }
    public RatingUserDto User { get; set; }
}