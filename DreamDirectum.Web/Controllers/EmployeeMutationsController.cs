using DreamDirectum.Core.Interfaces;
using DreamDirectum.UseCases.Queries.EmployeeQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DreamDirectum.Web.Controllers
{
    [Route("/api/v1/[controller]")]
    [ApiController]
    public class EmployeeMutationsController : AbstractController
    {
        public EmployeeMutationsController(IUserAuthTokenService userAuthTokenService, IMediator mediator) 
            : base(userAuthTokenService, mediator)
        { }

        [HttpGet("")]
        public async Task<IActionResult> GetAll(int limit, int offset)
        {
            await SetAuthTokenToService();
            return Ok(await mediator.Send(new GetAllEmployeesQuery { Limit = limit, Offset = offset }));
        }
    }
}
