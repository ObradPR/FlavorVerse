using FlavorVerse.Application.Dtos.User;

namespace FlavorVerse.Application.Dtos.Rating;

public class RatingDto : BaseDto
{
    public Guid Id { get; set; }
    public int RatingValue { get; set; }
    public string Comment { get; set; } = string.Empty;
    public RatingUserDto User { get; set; }
}