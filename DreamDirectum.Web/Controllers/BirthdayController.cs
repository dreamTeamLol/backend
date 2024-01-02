using DreamDirectum.Core.Interfaces;
using DreamDirectum.Core.Models.RequestModels;
using DreamDirectum.UseCases.Queries.MockEmployeeQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DreamDirectum.Web.Controllers
{
    [Route("/api/v1/[controller]")]
    [ApiController]
    public class BirthdayController : AbstractController
    {
        public BirthdayController(IUserAuthTokenService userAuthTokenService, IMediator mediator) 
            : base(userAuthTokenService, mediator)
        { }

        [HttpGet("")]
        public async Task<IActionResult> GetAll([FromQuery] DateOffsetParameters dateOffsetParameters)
        {
            //await SetAuthTokenToService();
            return Ok(await mediator.Send(new GetMockEmployeesBirthdaysInRangeQuery 
            { 
                DaysBefore = dateOffsetParameters.DaysBefore, 
                DaysAfter = dateOffsetParameters.DaysAfter 
            }));
        }
    }
}
