using DreamDirectum.Core.Interfaces;
using DreamDirectum.UseCases.Queries.EmployeeQueries;
using DreamDirectum.UseCases.Queries.MockEmployeeQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DreamDirectum.Web.Controllers
{
    [Route("/api/v1/[controller]")]
    [ApiController]
    public class EmployeeMutationController : AbstractController
    {
        public EmployeeMutationController(IUserAuthTokenService userAuthTokenService, IMediator mediator) 
            : base(userAuthTokenService, mediator)
        { }

        [HttpGet("")]
        public async Task<IActionResult> GetAll(int limit, int offset)
        {
            //await SetAuthTokenToService();
            return Ok(await mediator.Send(new GetMockEmployeeMutationsLogQuery { Limit = limit, Offset = offset }));
        }
    }
}
