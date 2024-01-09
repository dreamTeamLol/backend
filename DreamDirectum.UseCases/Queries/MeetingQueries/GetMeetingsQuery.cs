using AutoMapper;
using DreamDirectum.Core.Interfaces;
using DreamDirectum.Core.Models.Dtos;
using MediatR;
using Sungero.IntegrationService.Models.Generated.Meetings;

namespace DreamDirectum.UseCases.Queries.MeetingQueries
{
    public class GetMeetingsQuery : IRequest<MeetingDto[]>
    {
        public int Limit { get; set; }
        public int Offset { get; set; }
    }

    public class GetMeetingsQueryHandler : AbstractHandler, IRequestHandler<GetMeetingsQuery, MeetingDto[]>
    {
        private readonly IReadOnlyPaginalRepository<IMeetingDto, long> meetingRepository;

        public GetMeetingsQueryHandler
            (IUserAuthTokenService userAuthToken, 
            IMapper mapper,
            IReadOnlyPaginalRepository<IMeetingDto, long> meetingRepository) 
            : base(userAuthToken, mapper)
        {
            this.meetingRepository = meetingRepository;
        }

        public async Task<MeetingDto[]> Handle(GetMeetingsQuery request, CancellationToken cancellationToken)
        {
            var result = (await meetingRepository
                .GetAllWithPaginationAsync
                (userAuthToken.AuthToken,
                request.Limit,
                request.Offset,
                cancellationToken)).ToArray();

            return mapper.Map<IEnumerable<IMeetingDto>, MeetingDto[]>(result);
        }
    }
}
