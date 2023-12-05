using Microsoft.OData.Client;
using Sungero.IntegrationService;

namespace DreamDirectum.Infrastructure.Repositories
{
    public abstract class AbstractRepository
    {
        protected readonly Container container;

        protected AbstractRepository(Container container)
        {
            this.container = container;
        }

        protected void SetAuthorizationHeader(string authToken)
        {
            container.Configurations.RequestPipeline.OnMessageCreating = (args) =>
            {
                var message = new HttpClientRequestMessage(args);
                message.SetHeader("Authorization", $"Bearer {authToken}");

                return message;
            };
        }
    }
}
