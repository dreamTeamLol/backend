using Microsoft.AspNetCore.Http;

namespace DreamDirectum.Core.Interfaces
{
    public interface ITokenOptionsFactory
    {
        public CookieOptions CreateDirectumJwtTokenOptions();
    }
}
