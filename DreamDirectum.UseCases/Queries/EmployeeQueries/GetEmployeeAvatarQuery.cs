using AutoMapper;
using DreamDirectum.Core.Interfaces;
using MediatR;
using System.Net.Http.Headers;

namespace DreamDirectum.UseCases.Queries.EmployeeQueries
{
    public class GetEmployeeAvatarQuery : IRequest<Stream>
    {
        public long Id { get; set; }
    }

    public class GetEmployeeAvatarQueryHandler : AbstractHandler, IRequestHandler<GetEmployeeAvatarQuery, Stream>
    {
        public GetEmployeeAvatarQueryHandler
            (IUserAuthTokenService userAuthToken, 
            IMapper mapper) 
            : base(userAuthToken, mapper)
        { }

        public async Task<Stream> Handle(GetEmployeeAvatarQuery request, CancellationToken cancellationToken)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization
                = new AuthenticationHeaderValue("Bearer", userAuthToken.AuthToken);

            var response = await httpClient
                .GetAsync($"https://drim-student.starkovgrp.ru/Integration/odata/iemployees/" +
                $"{request.Id}/PersonalPhoto/$value");

            return response.IsSuccessStatusCode 
                ? await response.Content.ReadAsStreamAsync() 
                : null;
        }
    }
}
