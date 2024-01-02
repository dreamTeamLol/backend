using DreamDirectum.Core.Models.Dtos;
using MediatR;

namespace DreamDirectum.UseCases.Queries.MockEmployeeQueries
{
    public class GetMockEmployeesBirthdaysInRangeQuery : IRequest<EmployeeDto[]>
    {
        public int DaysBefore { get; set; }
        public int DaysAfter { get; set; }
    }

    public class GetMockEmployeesBirthdaysInRangeQueryHandler : IRequestHandler<GetMockEmployeesBirthdaysInRangeQuery, EmployeeDto[]>
    {
        private readonly EmployeeDto[] employees =
        {
            new EmployeeDto { Id = 1, FullName = "Потейчук Марина Семеновна", JobTitle = "Главный бухгалтер", DepartmentName = "Управление бухгалтерского учета и отчетности", DateOfBirth = new DateTime(1980, 7, 7) },
            new EmployeeDto { Id = 2, FullName = "Вишнева Диана Алексеевна", JobTitle = "Начальник отдела", DepartmentName = "Отдел по работе с персоналом", DateOfBirth = new DateTime(1980, 7, 10) }
        };

        public Task<EmployeeDto[]> Handle(GetMockEmployeesBirthdaysInRangeQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(employees);
        }
    }
}
