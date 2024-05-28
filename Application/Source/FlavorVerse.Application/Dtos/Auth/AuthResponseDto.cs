namespace FlavorVerse.Application.Dtos.Auth;

public class AuthResponseDto : BaseDto
{
    public string DisplayName { get; set; } = string.Empty;
    public string Token { get; set; } = string.Empty;
}