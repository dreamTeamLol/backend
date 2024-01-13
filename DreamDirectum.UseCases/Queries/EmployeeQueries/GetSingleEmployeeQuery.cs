using AutoMapper;
using DreamDirectum.Core.Interfaces;
using DreamDirectum.Core.Models.Dtos;
using MediatR;
using Sungero.IntegrationService.Models.Generated.NewDreamSolution;

namespace DreamDirectum.UseCases.Queries.EmployeeQueries
{
    public class GetSingleEmployeeQuery : IRequest<EmployeeDto>
    {
        public long Id { get; set; }
    }

    public class GetSingleEmployeeQueryHandler : AbstractHandler, IRequestHandler<GetSingleEmployeeQuery, EmployeeDto>
    {
        private readonly IReadOnlyRepository<IEmployeeDto, long> employeeRepository;

        public GetSingleEmployeeQueryHandler
            (IUserAuthTokenService userAuthToken, 
            IMapper mapper,
            IReadOnlyRepository<IEmployeeDto, long> employeeRepository) 
            : base(userAuthToken, mapper)
        {
            this.employeeRepository = employeeRepository;
        }

        public async Task<EmployeeDto> Handle(GetSingleEmployeeQuery request, CancellationToken cancellationToken)
        {
            var result = await employeeRepository
                .GetByIdAsync(userAuthToken.AuthToken, request.Id, cancellationToken);

            return mapper.Map<IEmployeeDto, EmployeeDto>(result);
        }
    }
}
