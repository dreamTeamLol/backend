using DreamDirectum.Core.Interfaces;
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
        public async Task<IActionResult> GetAll(int limit, int offset)
        {
            return Ok(await mediator.Send(new GetMockSubstitutionsQuery { Limit = limit, Offset = offset }));
        }
    }
}
