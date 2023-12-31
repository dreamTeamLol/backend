﻿using DreamDirectum.Core.Models.Dtos;
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
                Mutation = new MutationDto { AppliedDate = new DateTime(2023, 7, 29), Id = 1, Name = "Прием на работу" }
            },
            new MutationRecordDto
            {
                Employee = new EmployeeDto { FullName = "Сидорова Светлана Николаевна", JobTitle = "Главный специалист отдела кадров", Phone = "243" },
                Mutation = new MutationDto { AppliedDate = new DateTime(2023, 7, 29), Id = 2, Name = "Изменение данных" }
            },
            new MutationRecordDto
            {
                Employee = new EmployeeDto { FullName = "Петров Олег Сергеевич", JobTitle = "Ведущий специалист АХО", Phone = "243" },
                Mutation = new MutationDto { AppliedDate = new DateTime(2023, 8, 3), Id = 3, Name = "Увольнение" }
            },
        };

        public Task<MutationRecordDto[]> Handle(GetMockEmployeeMutationsLogQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(mutations.Skip(request.Offset).Take(request.Limit).ToArray());
        }
    }

}
