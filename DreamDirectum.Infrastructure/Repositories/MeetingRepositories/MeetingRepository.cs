using DreamDirectum.Core.Interfaces;
using Sungero.IntegrationService;
using Sungero.IntegrationService.Models.Generated.Meetings;

namespace DreamDirectum.Infrastructure.Repositories.MeetingRepositories
{
    public class MeetingRepository
        : AbstractRepository,
        IReadOnlyPaginalRepository<IMeetingDto, long>,
        IReadOnlyRepository<IMeetingDto, long>
    {
        public MeetingRepository(Container container) : base(container)
        { }

        public Task<IEnumerable<IMeetingDto>> GetAllWithPaginationAndSpecifiedOptionsAsync(string authToken, int limit, int offset, CancellationToken cancellationToken = default, params (string key, string value)[] options)
        {
            SetAuthorizationHeader(authToken);
            var result = container.IMeetings
                .AddQueryOption("$top", limit)
                .AddQueryOption("$skip", offset);

            foreach (var option in options)
            {
                result = result.AddQueryOption(option.key, option.value);
            }

            result = result.Expand("Members($expand=Member)")
                .Expand("Secretary")
                .Expand("President");

            return Task.FromResult(result.AsEnumerable());
        }

        public Task<IEnumerable<IMeetingDto>> GetAllWithPaginationAsync(string authToken, int limit, int offset, CancellationToken cancellationToken = default)
        {
            SetAuthorizationHeader(authToken);
            return Task.FromResult(container.IMeetings
                .AddQueryOption("$top", limit)
                .AddQueryOption("$skip", offset)
                .Expand("Members($expand=Member)")
                .Expand("Secretary")
                .Expand("President")
                .AsEnumerable());
        }

        public Task<IMeetingDto?> GetByIdAsync(string authToken, long id, CancellationToken cancellationToken = default)
        {
            SetAuthorizationHeader(authToken);
            return Task.FromResult(container.IMeetings
                .Expand("Members($expand=Member)")
                .Expand("Secretary")
                .Expand("President")
                .Where(e => e.Id == id)
                .SingleOrDefault());
        }

        public Task<IMeetingDto?> GetByIdWithSpecifiedOptionsAsync(string authToken, long id, CancellationToken cancellationToken = default, params (string key, string value)[] options)
        {
            SetAuthorizationHeader(authToken);
            var result = container.IMeetings;

            foreach (var option in options)
            {
                result = result.AddQueryOption(option.key, option.value);
            }

            result = result.Expand("Members($expand=Member)")
                .Expand("Secretary")
                .Expand("President");

            return Task
                .FromResult
                (result.Where(e => e.Id == id)
                .SingleOrDefault());
        }
    }
}
