using DreamDirectum.Core.Interfaces;
using DreamDirectum.Core.Models.RequestModels;
using DreamDirectum.UseCases.Queries.MockSubstitutionQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DreamDirectum.Web.Controllers
{
    [Route("/api/v1/[controller]")]
    [ApiController]
    public class SubstitutionController : AbstractController
    {
        public SubstitutionController(IUserAuthTokenService userAuthTokenService, IMediator mediator) : base(userAuthTokenService, mediator)
        { }

        [HttpGet("")]
        public async Task<IActionResult> GetAll([FromQuery] PaginationParameters paginationParameters)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(await mediator.Send(new GetMockSubstitutionsQuery 
            { 
                Limit = paginationParameters.Limit, 
                Offset = paginationParameters.Offset 
            }));
        }
    }
}
