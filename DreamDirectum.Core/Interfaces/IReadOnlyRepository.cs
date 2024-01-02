namespace DreamDirectum.Core.Interfaces
{
    public interface IReadOnlyRepository<T, TId> 
        where T : class 
        where TId : notnull
    {
        Task<T?> GetByIdAsync(string authToken, TId id, CancellationToken cancellationToken = default);
        Task<T?> GetByIdWithSpecifiedOptionsAsync(string authToken, TId id, CancellationToken cancellationToken = default, params (string key, string value)[] options);
    }

    public interface IReadOnlySinglePageRepository<T, TId>
        where T : class
        where TId : notnull
    {
        Task<IEnumerable<T>> GetAllAsync(string authToken, CancellationToken cancellationToken = default);
        Task<IEnumerable<T>> GetAllWithSpecifiedOptionsAsync(string authToken, CancellationToken cancellationToken = default, params (string key, string value)[] options);
    } 

    public interface IReadOnlyPaginalRepository<T, TId> 
        where T : class
        where TId : notnull
    {
        Task<IEnumerable<T>> GetAllWithPaginationAsync(string authToken, int limit, int offset, CancellationToken cancellationToken = default);
        Task<IEnumerable<T>> GetAllWithPaginationAndSpecifiedOptionsAsync(string authToken, int limit, int offset, CancellationToken cancellationToken = default, params (string key, string value)[] options);
    }
}
