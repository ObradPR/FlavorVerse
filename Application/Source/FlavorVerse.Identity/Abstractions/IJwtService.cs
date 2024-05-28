namespace FlavorVerse.Application.Identity.Abstractions
{
    public interface IJwtService
    {
        string GenerateJwtToken(Guid userId, string[] roles);
    }
}