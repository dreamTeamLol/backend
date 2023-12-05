using DreamDirectum.Core.Interfaces;

namespace DreamDirectum.Core.Services
{
    public class UserAuthTokenService : IUserAuthTokenService
    {
        public string AuthToken { get; private set; }

        public void SetAuthToken(string token)
        {
            if (string.IsNullOrEmpty(AuthToken))
            {
                AuthToken = token;
            }
        }
    }
}
