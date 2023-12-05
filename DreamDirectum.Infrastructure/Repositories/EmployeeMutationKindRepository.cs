using DreamDirectum.Core.Interfaces;
using Sungero.IntegrationService;
using Sungero.IntegrationService.Models.Generated.EmployeeModule;

namespace DreamDirectum.Infrastructure.Repositories
{
    public class EmployeeMutationKindRepository : AbstractRepository, IReadOnlyRepository<IEmployeeMutationKindDto, long>
    {
        public EmployeeMutationKindRepository(Container container) : base(container)
        { }

        public Task<IEnumerable<IEmployeeMutationKindDto>> GetAllAsync(string authToken, CancellationToken cancellationToken = default)
        {
            SetAuthorizationHeader(authToken);
            return Task.FromResult(container.IEmployeeMutationKinds.AsEnumerable());
        }

        public Task<IEnumerable<IEmployeeMutationKindDto>> GetAllWithPaginationAsync(string authToken, int limit, int offset, CancellationToken cancellationToken = default)
        {
            SetAuthorizationHeader(authToken);
            return Task.FromResult(container.IEmployeeMutationKinds
                .AddQueryOption("$top", limit)
                .AddQueryOption("$skip", offset)
                .AsEnumerable());
        }

        public Task<IEmployeeMutationKindDto?> GetByIdAsync(string authToken, long id, CancellationToken cancellationToken = default)
        {
            SetAuthorizationHeader(authToken);
            return Task.FromResult(container.IEmployeeMutationKinds.Where(e => e.Id == id).SingleOrDefault());
        }
    }
}
