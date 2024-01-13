using DreamDirectum.Core.Interfaces;
using Microsoft.AspNetCore.Http;

namespace DreamDirectum.Core.Factories
{
    public class TokenOptionsFactory : ITokenOptionsFactory
    {
        public CookieOptions CreateDirectumJwtTokenOptions()
        {
            return new CookieOptions
            {
                Path = "/",
                SameSite = Microsoft.AspNetCore.Http.SameSiteMode.None,
                Domain = "directum.snedson.com",
                Secure = true,
                HttpOnly = true,
                Expires = DateTime.MaxValue
            };
        }
    }
}
