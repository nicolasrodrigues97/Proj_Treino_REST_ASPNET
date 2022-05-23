using System.Collections.Generic;
using System.Security.Claims;

namespace Proj_Treino_REST_ASPNET.Services
{
    public interface ITokenService
    {
        string GenerateAccessToken(IEnumerable<Claim> claims);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}