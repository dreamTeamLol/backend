namespace DreamDirectum.Core.Models.RequestModels
{
    public record CredentialsRequest
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
