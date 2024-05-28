namespace FlavorVerse.Application.Dtos.Auth
{
    public class SignInDto : BaseDto
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
