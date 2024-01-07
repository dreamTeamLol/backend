using AutoMapper;
using DreamDirectum.Core.Interfaces;
using DreamDirectum.Core.Models.Dtos;
using MediatR;
using Sungero.IntegrationService.Models.Generated.EmployeeMutationsModule;
using Sungero.IntegrationService.Models.Generated.NewDreamSolution;

namespace DreamDirectum.UseCases.Queries.EmployeeQueries
{
    public class GetEmployeeMutationsLogQuery : IRequest<MutationRecordDto[]>
    {
        public int Limit { get; set; }
        public int Offset { get; set; }
    }

    public class GetEmployeeMutationsLogQueryHandler : IRequestHandler<GetEmployeeMutationsLogQuery, MutationRecordDto[]>
    {
        private readonly IReadOnlyPaginalRepository<IEmployeeMutationsLogDto, long> mutationLogRepository;
        private readonly IUserAuthTokenService userAuthToken;
        private readonly IMapper mapper;

        public GetEmployeeMutationsLogQueryHandler
            (IReadOnlyPaginalRepository<IEmployeeMutationsLogDto, long> mutationLogRepository,
            IUserAuthTokenService userAuthToken,
            IMapper mapper)
        {
            this.mutationLogRepository = mutationLogRepository;
            this.userAuthToken = userAuthToken;
            this.mapper = mapper;
        }

        public async Task<MutationRecordDto[]> Handle(GetEmployeeMutationsLogQuery request, CancellationToken cancellationToken)
        {
            var result = await mutationLogRepository
                .GetAllWithPaginationAsync
                (userAuthToken.AuthToken,
                request.Limit,
                request.Offset,
                cancellationToken);

            return mapper.Map<IEnumerable<IEmployeeMutationsLogDto>, MutationRecordDto[]>(result);
        }
    }
}
