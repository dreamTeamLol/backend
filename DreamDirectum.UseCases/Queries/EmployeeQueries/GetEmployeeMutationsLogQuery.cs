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

    public class GetEmployeeMutationsLogQueryHandler : AbstractHandler, IRequestHandler<GetEmployeeMutationsLogQuery, MutationRecordDto[]>
    {
        private readonly IReadOnlyPaginalRepository<IEmployeeMutationsLogDto, long> mutationLogRepository;

        public GetEmployeeMutationsLogQueryHandler
            (IUserAuthTokenService userAuthToken, 
            IMapper mapper,
            IReadOnlyPaginalRepository<IEmployeeMutationsLogDto, long> mutationLogRepository) 
            : base(userAuthToken, mapper)
        {
            this.mutationLogRepository = mutationLogRepository;
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
