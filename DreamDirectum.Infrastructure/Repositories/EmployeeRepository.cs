using DreamDirectum.Core.Interfaces;
using Sungero.IntegrationService;
using Sungero.IntegrationService.Models.Generated.DreamSolution;
using System.Collections.Generic;

namespace DreamDirectum.Infrastructure.Repositories
{
    public class EmployeeRepository 
        : AbstractRepository, 
        IReadOnlyPaginalRepository<IEmployeeDto, long>,
        IReadOnlyRepository<IEmployeeDto, long>,
        IReadOnlySinglePageRepository<IEmployeeDto, long>
    {
        public EmployeeRepository(Container container) : base(container)
        { }

        public Task<IEnumerable<IEmployeeDto>> GetAllWithPaginationAsync(string authToken, int limit, int offset, CancellationToken cancellationToken = default)
        {
            SetAuthorizationHeader(authToken);
            return Task.FromResult(container.IEmployees
                .AddQueryOption("$top", limit)
                .AddQueryOption("$skip", offset)
                .Expand("MutationsStudent")
                .Expand("Department") // TODO : Also expand a birthday
                .AsEnumerable());
        }

        public Task<IEnumerable<IEmployeeDto>> GetAllWithPaginationAndSpecifiedOptionsAsync(string authToken, int limit, int offset, CancellationToken cancellationToken = default, params (string key, string value)[] options)
        {
            SetAuthorizationHeader(authToken);
            var result = container.IEmployees
                .AddQueryOption("$top", limit)
                .AddQueryOption("$skip", offset);

            foreach(var option in options)
            {
                result = result.AddQueryOption(option.key, option.value);
            }

            result = result.Expand("MutationsStudent")
                .Expand("Department"); // TODO : Also expand a birthday

            return Task.FromResult(result.AsEnumerable());
        }

        public Task<IEmployeeDto?> GetByIdAsync(string authToken, long id, CancellationToken cancellationToken = default)
        {
            SetAuthorizationHeader(authToken);
            return Task.FromResult(container.IEmployees.Where(e => e.Id == id).SingleOrDefault());
        }

        public Task<IEmployeeDto?> GetByIdWithSpecifiedOptionsAsync(string authToken, long id, CancellationToken cancellationToken = default, params (string key, string value)[] options)
        {
            SetAuthorizationHeader(authToken);
            var result = container.IEmployees;

            foreach (var option in options)
            {
                result = result.AddQueryOption(option.key, option.value);
            }

            return Task.FromResult(result.Where(e => e.Id == id).SingleOrDefault());
        }

        public Task<IEnumerable<IEmployeeDto>> GetAllAsync(string authToken, CancellationToken cancellationToken = default)
        {
            SetAuthorizationHeader(authToken);
            return Task.FromResult(container.IEmployees
                .Expand("MutationsStudent")
                .Expand("Department") // TODO : Also expand a birthday
                .AsEnumerable());
        }

        public Task<IEnumerable<IEmployeeDto>> GetAllWithSpecifiedOptionsAsync(string authToken, CancellationToken cancellationToken = default, params (string key, string value)[] options)
        {
            SetAuthorizationHeader(authToken);
            var result = container.IEmployees;

            foreach (var option in options)
            {
                result = result.AddQueryOption(option.key, option.value);
            }

            result = result.Expand("MutationsStudent")
                .Expand("Department"); // TODO : Also expand a birthday

            return Task.FromResult(result.AsEnumerable());
        }
    }
}
