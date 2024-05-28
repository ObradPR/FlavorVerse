using FlavorVerse.Application.Identity.Abstractions;
using FlavorVerse.Application.Identity.Utilities;
using Microsoft.Extensions.Configuration;

namespace FlavorVerse.Application.Identity.Services
{
    public class AuthenticationService : IJwtService
    {
        private readonly JwtUtility _jwtUtility;

        public AuthenticationService(IConfiguration configuration) => _jwtUtility = new JwtUtility(configuration);

        public string GenerateJwtToken(Guid userId, string[] roles)
        {
            return _jwtUtility.GenerateToken(userId, roles);
        }
    }
}