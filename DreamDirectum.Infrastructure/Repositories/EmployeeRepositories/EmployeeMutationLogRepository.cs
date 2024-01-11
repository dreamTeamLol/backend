using DreamDirectum.Core.Interfaces;
using Microsoft.OData.Client;
using Sungero.IntegrationService;
using Sungero.IntegrationService.Models.Generated.EmployeeMutationsModule;

namespace DreamDirectum.Infrastructure.Repositories.EmployeeRepositories
{
    public class EmployeeMutationLogRepository
        : AbstractRepository,
        IReadOnlyPaginalRepository<IEmployeeMutationsLogDto, long>,
        IReadOnlyRepository<IEmployeeMutationsLogDto, long>
    {
        public EmployeeMutationLogRepository(Container container) : base(container)
        { }

        public Task<IEnumerable<IEmployeeMutationsLogDto>> GetAllWithPaginationAndSpecifiedOptionsAsync(string authToken, int limit, int offset, CancellationToken cancellationToken = default, params (string key, string value)[] options)
        {
            SetAuthorizationHeader(authToken);
            var result = container.IEmployeeMutationsModuleEmployeeMutationsLogs
                .AddQueryOption("$top", limit)
                .AddQueryOption("$skip", offset);

            foreach (var option in options)
            {
                result = result.AddQueryOption(option.key, option.value);
            }

            result = result.Expand("Employee($expand=Department,Person,JobTitle)");
            return Task.FromResult(result.AsEnumerable());
        }

        public Task<IEnumerable<IEmployeeMutationsLogDto>> GetAllWithPaginationAsync(string authToken, int limit, int offset, CancellationToken cancellationToken = default)
        {
            SetAuthorizationHeader(authToken);
            return Task.FromResult(container.IEmployeeMutationsModuleEmployeeMutationsLogs
                .AddQueryOption("$top", limit)
                .AddQueryOption("$skip", offset)
                .Expand("Employee($expand=Department,Person,JobTitle)")
                .AsEnumerable());
        }

        public Task<IEmployeeMutationsLogDto?> GetByIdAsync(string authToken, long id, CancellationToken cancellationToken = default)
        {
            SetAuthorizationHeader(authToken);
            return Task.FromResult
                (container
                .IEmployeeMutationsModuleEmployeeMutationsLogs
                .Expand("Employee($expand=Department,Person,JobTitle)")
                .Where(e => e.Id == id)
                .SingleOrDefault());
        }

        public Task<IEmployeeMutationsLogDto?> GetByIdWithSpecifiedOptionsAsync(string authToken, long id, CancellationToken cancellationToken = default, params (string key, string value)[] options)
        {
            SetAuthorizationHeader(authToken);
            var result = container.IEmployeeMutationsModuleEmployeeMutationsLogs;

            foreach (var option in options)
            {
                result = result.AddQueryOption(option.key, option.value);
            }

            result = result.Expand("Employee($expand=Department,Person,JobTitle)");

            return Task.FromResult(result.Where(e => e.Id == id).SingleOrDefault());
        }
    }
}
