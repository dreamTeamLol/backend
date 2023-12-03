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
    }
}
