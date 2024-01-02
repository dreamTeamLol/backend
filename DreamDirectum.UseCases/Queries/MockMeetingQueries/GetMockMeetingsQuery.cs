using DreamDirectum.Core.Models.Dtos;
using MediatR;

namespace DreamDirectum.UseCases.Queries.MockMeetingQueries
{
    public class GetMockMeetingsQuery : IRequest<MeetingDto[]>
    { }

    public class GetMockMeetingsQueryHandler : IRequestHandler<GetMockMeetingsQuery, MeetingDto[]>
    {
        private readonly MeetingDto[] meetings =
        {
            new MeetingDto
            {
                Name = "Заседание Координационного совета  по организации защиты прав застрахованных",
                DisplayName = "Заседание Координационного совета  по организации защиты прав застрахованных",
                DateTime = new DateTime(2023, 5, 31),
                Location = "Конференц-зал, 8 этаж",
                Secretary = new EmployeeDto { FullName = "Киселева С.О." },
                President = new EmployeeDto { FullName = "Титкова Н.Г." },
                Members = new EmployeeDto[]
                {
                    new EmployeeDto { FullName = "Кальницкий" },
                    new EmployeeDto { FullName = "Фатихов" },
                    new EmployeeDto { FullName = "Британова" },
                },
                Note = "приглашенные сотрудники СМО по ВКС"
            }
        };

        public Task<MeetingDto[]> Handle(GetMockMeetingsQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(meetings);
        }
    }
}
