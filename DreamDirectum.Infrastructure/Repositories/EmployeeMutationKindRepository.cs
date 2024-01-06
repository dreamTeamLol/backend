/*using DreamDirectum.Core.Interfaces;
using Sungero.IntegrationService;
using Sungero.IntegrationService.Models.Generated.EmployeeMutationsModule;

namespace DreamDirectum.Infrastructure.Repositories
{
    public class EmployeeMutationKindRepository 
        : AbstractRepository, 
        IReadOnlySinglePageRepository<IEmployeeMutationKindDto, long>,
        IReadOnlyRepository<IEmployeeMutationKindDto, long>
    {
        public EmployeeMutationKindRepository(Container container) : base(container)
        { }

        public Task<IEnumerable<IEmployeeMutationKindDto>> GetAllAsync(string authToken, CancellationToken cancellationToken = default)
        {
            SetAuthorizationHeader(authToken);
            return Task.FromResult(container.IEmployeeMutationKinds.AsEnumerable());
        }

        public Task<IEnumerable<IEmployeeMutationKindDto>> GetAllWithSpecifiedOptionsAsync(string authToken, CancellationToken cancellationToken = default, params (string key, string value)[] options)
        {
            SetAuthorizationHeader(authToken);
            var result = container.IEmployeeMutationKinds;

            foreach (var option in options)
            {
                result = result.AddQueryOption(option.key, option.value);
            }

            return Task.FromResult(result.AsEnumerable());
        }

        public Task<IEmployeeMutationKindDto?> GetByIdAsync(string authToken, long id, CancellationToken cancellationToken = default)
        {
            SetAuthorizationHeader(authToken);
            return Task.FromResult(container.IEmployeeMutationKinds.Where(e => e.Id == id).SingleOrDefault());
        }

        public Task<IEmployeeMutationKindDto?> GetByIdWithSpecifiedOptionsAsync(string authToken, long id, CancellationToken cancellationToken = default, params (string key, string value)[] options)
        {
            SetAuthorizationHeader(authToken);
            var result = container.IEmployeeMutationKinds;

            foreach (var option in options)
            {
                result = result.AddQueryOption(option.key, option.value);
            }

            return Task.FromResult(result.Where(e => e.Id == id).SingleOrDefault());
        }
    }
}
*/