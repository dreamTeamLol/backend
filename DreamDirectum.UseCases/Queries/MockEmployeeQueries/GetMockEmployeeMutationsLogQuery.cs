using DreamDirectum.Core.Models.Dtos;
using MediatR;

namespace DreamDirectum.UseCases.Queries.MockEmployeeQueries
{
    public class GetMockEmployeeMutationsLogQuery : IRequest<MutationRecordDto[]>
    {
        public int Limit { get; set; }
        public int Offset { get; set; }
    }

    public class GetMockEmployeeMutationsLogQueryHandler : IRequestHandler<GetMockEmployeeMutationsLogQuery, MutationRecordDto[]>
    {
        private readonly MutationRecordDto[] mutations =
        {
            new MutationRecordDto
            {
                Employee = new EmployeeDto { FullName = "Иванов Сидор Петрович", JobTitle = "Главный специалист отдела экспертизы", Phone = "243" },
                Mutation = "Прием на работу", AppliedDate = new DateTime(2023, 7, 29),
            },
            new MutationRecordDto
            {
                Employee = new EmployeeDto { FullName = "Сидорова Светлана Николаевна", JobTitle = "Главный специалист отдела кадров", Phone = "243" },
                Mutation = "Изменение данных", AppliedDate = new DateTime(2023, 7, 29),
            },
            new MutationRecordDto
            {
                Employee = new EmployeeDto { FullName = "Петров Олег Сергеевич", JobTitle = "Ведущий специалист АХО", Phone = "243" },
                Mutation = "Увольнение", AppliedDate = new DateTime(2023, 8, 3),
            },
        };

        public Task<MutationRecordDto[]> Handle(GetMockEmployeeMutationsLogQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(mutations.Skip(request.Offset).Take(request.Limit).ToArray());
        }
    }

}
