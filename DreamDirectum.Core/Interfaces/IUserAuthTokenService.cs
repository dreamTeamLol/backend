namespace DreamDirectum.Core.Interfaces
{
    public interface IUserAuthTokenService
    {
        string AuthToken { get; }
        void SetAuthToken(string token);
    }
}
