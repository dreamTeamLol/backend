using DreamDirectum.Core.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DreamDirectum.Web.Controllers
{
    public abstract class AbstractController : ControllerBase
    {
        private readonly IUserAuthTokenService userAuthTokenService;
        protected readonly IMediator mediator;

        public AbstractController(IUserAuthTokenService userAuthTokenService, IMediator mediator)
        {
            this.userAuthTokenService = userAuthTokenService;
            this.mediator = mediator;
        }

        protected async Task SetAuthTokenToService()
        {
            userAuthTokenService.SetAuthToken(await IssueTempAuthToken());
        }

        private async Task<string> IssueTempAuthToken()
        {
            var httpClient = new HttpClient();

            var getTokenUrl = "https://drim-student.starkovgrp.ru/Integration/token";

            var tokenRequest = new HttpRequestMessage(HttpMethod.Get, getTokenUrl);

            tokenRequest.Headers.Add("username", "Service User");

            tokenRequest.Headers.Add("password", "111111");

            var tokenResponce = await httpClient.SendAsync(tokenRequest);

            return await tokenResponce.Content.ReadAsStringAsync();
        }
    }
}
