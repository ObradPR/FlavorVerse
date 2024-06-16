namespace FlavorVerse.Application.Dtos.User;

public class RatingUserDto : BaseDto
{
    public Guid Id { get; set; }
    public string DisplayName { get; set; } = string.Empty;
}