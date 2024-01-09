using DreamDirectum.Core.Interfaces;
using Sungero.IntegrationService;
using Sungero.IntegrationService.Models.Generated.CoreEntities;

namespace DreamDirectum.Infrastructure.Repositories.SubstitutionRepositories
{
    public class SubstitutionRepository
        : AbstractRepository,
        IReadOnlyPaginalRepository<ISubstitutionDto, long>,
        IReadOnlyRepository<ISubstitutionDto, long>
    {
        public SubstitutionRepository(Container container) : base(container)
        { }

        public Task<IEnumerable<ISubstitutionDto>> GetAllWithPaginationAndSpecifiedOptionsAsync(string authToken, int limit, int offset, CancellationToken cancellationToken = default, params (string key, string value)[] options)
        {
            SetAuthorizationHeader(authToken);
            var result = container.ISubstitutions
                .AddQueryOption("$top", limit)
                .AddQueryOption("$skip", offset);

            foreach (var option in options)
            {
                result = result.AddQueryOption(option.key, option.value);
            }

            result = result.Expand("User")
                .Expand("Substitute");
            return Task.FromResult(result.AsEnumerable());
        }

        public Task<IEnumerable<ISubstitutionDto>> GetAllWithPaginationAsync(string authToken, int limit, int offset, CancellationToken cancellationToken = default)
        {
            SetAuthorizationHeader(authToken);
            return Task.FromResult(container.ISubstitutions
                .AddQueryOption("$top", limit)
                .AddQueryOption("$skip", offset)
                .Expand("User")
                .Expand("Substitute")
                .AsEnumerable());
        }

        public Task<ISubstitutionDto?> GetByIdAsync(string authToken, long id, CancellationToken cancellationToken = default)
        {
            SetAuthorizationHeader(authToken);
            return Task.FromResult(container.ISubstitutions
                .Expand("User")
                .Expand("Substitute")
                .Where(e => e.Id == id)
                .SingleOrDefault());
        }

        public Task<ISubstitutionDto?> GetByIdWithSpecifiedOptionsAsync(string authToken, long id, CancellationToken cancellationToken = default, params (string key, string value)[] options)
        {
            SetAuthorizationHeader(authToken);
            var result = container.ISubstitutions;

            foreach (var option in options)
            {
                result = result.AddQueryOption(option.key, option.value);
            }

            result = result.Expand("User")
                .Expand("Substitute");

            return Task
                .FromResult
                (result.Where(e => e.Id == id)
                .SingleOrDefault());
        }
    }
}
