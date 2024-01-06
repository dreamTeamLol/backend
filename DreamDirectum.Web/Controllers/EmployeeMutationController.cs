using DreamDirectum.Core.Interfaces;
using DreamDirectum.Core.Models.RequestModels;
using DreamDirectum.UseCases.Queries.EmployeeQueries;
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
        public async Task<IActionResult> GetAll([FromQuery] PaginationParameters paginationParameters)
        {
            await SetAuthTokenToService();
            return Ok(await mediator.Send(new GetEmployeeMutationsLogQuery
            { 
                Limit = paginationParameters.Limit, 
                Offset = paginationParameters.Offset 
            }));
        }
    }
}
