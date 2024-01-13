using DreamDirectum.Core.Interfaces;
using DreamDirectum.Core.Models.RequestModels;
using DreamDirectum.UseCases.Queries.EmployeeQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DreamDirectum.Web.Controllers
{
    [Route("/api/v1/[controller]")]
    [ApiController]
    public class EmployeeController : AbstractController
    {
        public EmployeeController(IUserAuthTokenService userAuthTokenService, IMediator mediator) 
            : base(userAuthTokenService, mediator)
        { }

        [HttpGet("")]
        public async Task<IActionResult> GetAll([FromQuery] DateOffsetParameters dateOffsetParameters)
        {
            await SetAuthTokenToService();
            return Ok(await mediator.Send(new GetEmployeesBirthdaysInRangeQuery
            { 
                DaysBefore = dateOffsetParameters.BirthdayRangeLeftBorder, 
                DaysAfter = dateOffsetParameters.BirthdayRangeRightBorder,
            }));
        }

        [HttpGet("{id:long}")]
        public async Task<IActionResult> GetById([FromRoute] long id)
        {
            await SetAuthTokenToService();
            return Ok(await mediator.Send(new GetSingleEmployeeQuery
            {
                Id = id
            }));
        }
    }
}
