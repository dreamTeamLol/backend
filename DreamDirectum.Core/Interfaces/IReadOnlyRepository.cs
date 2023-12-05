using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamDirectum.Core.Interfaces
{
    public interface IReadOnlyRepository<T, TId> 
        where T : class 
        where TId : notnull
    {
        Task<IEnumerable<T>> GetAllAsync(string authToken, CancellationToken cancellationToken = default);
        Task<IEnumerable<T>> GetAllWithPaginationAsync(string authToken, int limit, int offset, CancellationToken cancellationToken = default);
        Task<T?> GetByIdAsync(string authToken, TId id, CancellationToken cancellationToken = default);
    }
}
