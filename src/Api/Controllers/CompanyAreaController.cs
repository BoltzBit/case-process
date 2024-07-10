using Microsoft.AspNetCore.Mvc;
using MediatR;
using CaseProcess.Application.Features.Commands;
using CaseProcess.Application.Features.Queries;

namespace Api.Controllers;

[ApiController]
[Route("company-area")]
public class CompanyAreaController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] GetAllCompanyAreaQuery query)
    {
        return Ok(await mediator.Send(query));
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateCompanyAreaCommand command)
    {
        return Ok(await mediator.Send(command));
    }
}

