using DreamDirectum.Core.Models.Dtos;
using MediatR;

namespace DreamDirectum.UseCases.Queries.AuthQueries
{
    public class IssueTokenQuery : IRequest<ResultWrapperDto>
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public class IssueTokenQueryHandler : IRequestHandler<IssueTokenQuery, ResultWrapperDto>
    {
        public IssueTokenQueryHandler()
        { }

        public async Task<ResultWrapperDto> Handle(IssueTokenQuery request, CancellationToken cancellationToken)
        {
            var httpClient = new HttpClient();
            var getTokenUrl = "https://drim-student.starkovgrp.ru/Integration/token";

            var tokenRequest = new HttpRequestMessage(HttpMethod.Get, getTokenUrl);

            tokenRequest.Headers.Add("username", request.Login);
            tokenRequest.Headers.Add("password", request.Password);

            var tokenResponse = await httpClient.SendAsync(tokenRequest);

            return new ResultWrapperDto
            {
                ResultStatus = (int)tokenResponse.StatusCode,
                ResultContent = await tokenResponse.Content.ReadAsStringAsync()
            };
        }
    }
}
