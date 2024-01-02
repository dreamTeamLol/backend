using DreamDirectum.Core.Models.Dtos;
using MediatR;  

namespace DreamDirectum.UseCases.Queries.MockSubstitutionQueries
{
    public class GetMockSubstitutionsQuery : IRequest<SubstitutionDto[]>
    {
        public int Limit { get; set; }
        public int Offset { get; set; }
    }

    public class GetMockSubstitutionsQueryHandler : IRequestHandler<GetMockSubstitutionsQuery, SubstitutionDto[]>
    {
        private readonly SubstitutionDto[] substitutions =
        {
            new SubstitutionDto
            {
                User = new EmployeeDto { FullName = "Иванов Сергей Петрович", JobTitle = "Начальник отдела КРУ" },
                Substitue = new EmployeeDto { FullName = "Сидоров Семен Васильевич", JobTitle = "Главный специалист КРУ" },
                StartDate = new DateTime(2023, 2, 1),
                EndDate = new DateTime(2023, 2, 23),
                Comment = "В отпуске"
            }
        };

        public Task<SubstitutionDto[]> Handle(GetMockSubstitutionsQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(substitutions);
        }
    }
}
 