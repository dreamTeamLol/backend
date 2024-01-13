using DreamDirectum.Core.Interfaces;
using DreamDirectum.Core.Models.RequestModels;
using DreamDirectum.UseCases.Queries.AuthQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DreamDirectum.Web.Controllers
{
    [Route("/api/v1/[controller]")]
    [ApiController]
    public class AuthController : AbstractController
    {
        private readonly ITokenOptionsFactory tokenOptionsFactory;

        public AuthController
            (IUserAuthTokenService userAuthTokenService, 
            IMediator mediator,
            ITokenOptionsFactory tokenOptionsFactory) 
            : base(userAuthTokenService, mediator)
        {
            this.tokenOptionsFactory = tokenOptionsFactory;
        }

        [HttpPost("")]
        public async Task<IActionResult> Token([FromBody] CredentialsRequest credentials)
        {
            var result = await mediator.Send(new IssueTokenQuery
            {
                Login = credentials.Login,
                Password = credentials.Password,
            });

            if(result.ResultStatus == (int)System.Net.HttpStatusCode.OK)
            {
                Response.Cookies.Append
                    ("directum_token", 
                    result.ResultContent.ToString(), 
                    tokenOptionsFactory.CreateDirectumJwtTokenOptions());
            }

            Response.StatusCode = result.ResultStatus;
            return new EmptyResult();
        }
    }
}
