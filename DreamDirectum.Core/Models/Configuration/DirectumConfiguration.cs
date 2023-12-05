namespace DreamDirectum.Core.Models.Configuration
{
    public class DirectumConfiguration
    {
        public string BaseUrl { get; set; }
        public string OdataIntegrationEndpoint { get; set; }
        public string OdataFullUrl { get => BaseUrl + OdataIntegrationEndpoint; }
    }
}
