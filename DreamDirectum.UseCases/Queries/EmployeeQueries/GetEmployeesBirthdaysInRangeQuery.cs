﻿using DreamDirectum.Core.Interfaces;
using DreamDirectum.Core.Models.Dtos;
using MediatR;
using Sungero.IntegrationService.Models.Generated.NewDreamSolution;
using System.Text;

namespace DreamDirectum.UseCases.Queries.EmployeeQueries
{
    public class GetEmployeesBirthdaysInRangeQuery : IRequest<EmployeeDto[]>
    {
        //public int Limit { get; set; }
        //public int Offset { get; set; }
        public int DaysBefore { get; set; }
        public int DaysAfter { get; set; }
    }

    public class GetEmployeesBirthdaysInRangeQueryHandler : IRequestHandler<GetEmployeesBirthdaysInRangeQuery, EmployeeDto[]>
    {
        private readonly IReadOnlySinglePageRepository<IEmployeeDto, long> employeeRespository;
        private readonly IUserAuthTokenService userAuthToken;

        public GetEmployeesBirthdaysInRangeQueryHandler
            (IReadOnlySinglePageRepository<IEmployeeDto, long> employeeRespository,
            IUserAuthTokenService userAuthToken)
        {
            this.employeeRespository = employeeRespository;
            this.userAuthToken = userAuthToken;
        }

        public async Task<EmployeeDto[]> Handle(GetEmployeesBirthdaysInRangeQuery request, CancellationToken cancellationToken)
        {
            return (await employeeRespository
                .GetAllWithSpecifiedOptionsAsync
                (userAuthToken.AuthToken,
                //request.Limit,
                //request.Offset,
                cancellationToken,
                [
                    ("$filter", BuildFilterDateString(request.DaysBefore, request.DaysAfter, "Person/DateOfBirth"))
                ]))
                .Select(e => new EmployeeDto
                {
                    Id = e.Id,
                    DateOfBirth = e.Person.DateOfBirth.Value.UtcDateTime,
                    DepartmentName = e.Department.Name,
                    FullName = e.Name,
                    JobTitle = e.JobTitle?.Name,
                    Phone = e.Phone
                })
                .ToArray();
        }

        private string BuildFilterDateString(int daysBefore, int daysAfter, string dateFieldName)
        {
            DateTime today = DateTime.Today;

            DateTime dateBefore = today.AddDays(-daysBefore);
            DateTime dateAfter = today.AddDays(daysAfter);

            var filterBuilder = new StringBuilder();

            if(dateBefore.Year != today.Year)
            {
                filterBuilder.Append($"(month({dateFieldName}) ge {dateBefore.Month} or month({dateFieldName}) le {today.Month})");
                // TODO: This filter is too lax. Implement day comparison just like in case of different mothes.
            }
            else
            {
                if (dateBefore.Month != today.Month)
                {
                    filterBuilder.Append($"((month({dateFieldName}) eq {dateBefore.Month} and day({dateFieldName}) ge {dateBefore.Day})" +
                                        $" or (month({dateFieldName}) gt {dateBefore.Month}))");
                }
                else
                {
                    filterBuilder.Append($"(month({dateFieldName}) eq {dateBefore.Month} and day({dateFieldName}) ge {dateBefore.Day})");
                }
            }

            if (dateAfter.Year != today.Year)
            {
                filterBuilder.Append($" or month({dateFieldName}) le {dateAfter.Month} or month({dateFieldName}) ge {today.Month}");
                // TODO: This filter is too lax. Implement day comparison just like in case of different mothes.
            }
            else
            {
                if (today.Month != dateAfter.Month)
                {
                    filterBuilder.Append($" or ((month({dateFieldName}) eq {dateAfter.Month} and day({dateFieldName}) le {dateAfter.Day})" +
                                     $" or (month({dateFieldName}) lt {dateAfter.Month}))");
                }
                else
                {
                    filterBuilder.Append($" or (month({dateFieldName}) eq {dateAfter.Month} and day({dateFieldName}) le {dateAfter.Day})");
                }

            }

            return filterBuilder.ToString();
        }
    }
}
