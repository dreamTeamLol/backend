using DreamDirectum.Core.Interfaces;
using DreamDirectum.Core.Models.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.OData.Client;
using Sungero.IntegrationService;
using Sungero.IntegrationService.Models.Generated.DreamSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DreamDirectum.Infrastructure.Repositories
{
    public class EmployeeRepository : AbstractRepository, IReadOnlyRepository<IEmployeeDto, long>
    {
        public EmployeeRepository(Container container) : base(container)
        { }

        public async Task<IEnumerable<IEmployeeDto>> GetAllAsync(string authToken, CancellationToken cancellationToken = default)
        {
            SetAuthorizationHeader(authToken);
            return container.IEmployees.Expand("MutationsStudent").ToList();
        }

        public Task<IEnumerable<IEmployeeDto>> GetAllWithPaginationAsync(string authToken, int limit, int offset, CancellationToken cancellationToken = default)
        {
            SetAuthorizationHeader(authToken);
            return Task.FromResult(container.IEmployees
                .AddQueryOption("$top", limit)
                .AddQueryOption("$skip", offset)
                .Expand("MutationsStudent")
                .Expand("Department")
                .AsEnumerable());
        }

        public Task<IEmployeeDto?> GetByIdAsync(string authToken, long id, CancellationToken cancellationToken = default)
        {
            SetAuthorizationHeader(authToken);
            return Task.FromResult(container.IEmployees.Where(e => e.Id == id).SingleOrDefault());
        }
    }
}
