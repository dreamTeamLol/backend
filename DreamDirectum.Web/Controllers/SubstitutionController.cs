using DreamDirectum.Core.Interfaces;
using DreamDirectum.Core.Models.RequestModels;
using DreamDirectum.UseCases.Queries.MockSubstitutionQueries;
using DreamDirectum.UseCases.Queries.SubstitutionQueries;
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

            await SetAuthTokenToService();
            return Ok(await mediator.Send(new GetSubstitutionsQuery
            { 
                Limit = paginationParameters.Limit, 
                Offset = paginationParameters.Offset 
            }));
        }
    }
}
