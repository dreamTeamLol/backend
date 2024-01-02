using DreamDirectum.Core.Interfaces;
using DreamDirectum.Core.Models.RequestModels;
using DreamDirectum.UseCases.Queries.MockSubstitutionQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DreamDirectum.Web.Controllers
{
    [Route("/api/v1/[controller]")]
    [ApiController]
    public class MeetingController : AbstractController
    {
        public MeetingController(IUserAuthTokenService userAuthTokenService, IMediator mediator) : base(userAuthTokenService, mediator)
        { }

        [HttpGet("")]
        public async Task<IActionResult> GetAll([FromQuery] PaginationParameters paginationParameters)
        {
            return Ok(await mediator.Send(new GetMockSubstitutionsQuery 
            { 
                Limit = paginationParameters.Limit, 
                Offset = paginationParameters.Offset 
            }));
        }
    }
}
