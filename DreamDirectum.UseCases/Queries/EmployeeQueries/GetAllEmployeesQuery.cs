using DreamDirectum.Core.Interfaces;
using DreamDirectum.Core.Models.Dtos;
using DreamDirectum.Infrastructure.Repositories;
using MediatR;

namespace DreamDirectum.UseCases.Queries.EmployeeQueries
{
    public class GetAllEmployeesQuery : IRequest<EmployeeDto[]>
    {
        public int Limit { get; set; }
        public int Offset { get; set; }
    }

    public class GetAllEmployeesHandler : IRequestHandler<GetAllEmployeesQuery, EmployeeDto[]>
    {
        private readonly EmployeeRepository employeeRepository;
        private readonly EmployeeMutationKindRepository employeeMutationKindRepository;
        private readonly IUserAuthTokenService userAuthToken;

        public GetAllEmployeesHandler(EmployeeRepository employeeRepository, 
            EmployeeMutationKindRepository employeeMutationKindRepository, 
            IUserAuthTokenService userAuthToken)
        {
            this.employeeRepository = employeeRepository;
            this.employeeMutationKindRepository = employeeMutationKindRepository;
            this.userAuthToken = userAuthToken;
        }

        public async Task<EmployeeDto[]> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
        {
            var employees = await employeeRepository
                .GetAllWithPaginationAsync(userAuthToken.AuthToken, request.Limit, request.Offset);
            var mutationKinds = await employeeMutationKindRepository.GetAllAsync(userAuthToken.AuthToken);

            var mutationDictionary = mutationKinds.ToDictionary(m => m.Id, m => m.Name);

            return (employees)
                .Select(e => new EmployeeDto
                {
                    Id = e.Id,
                    FullName = e.Name,
                    DepartmentName = e.Department.Name,
                    Mutations = e.MutationsStudent
                        .Select(m => new MutationDto
                        {
                            Id = m.Id,
                            Name = mutationDictionary[m.Id],
                            AppliedDate = m.AppliedDate,
                            Note = m.Note
                        }).ToArray()
                }).ToArray();
        }
    }
}
