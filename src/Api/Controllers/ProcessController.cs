using Microsoft.AspNetCore.Mvc;
using CaseProcess.Application.Features.Commands;
using CaseProcess.Application.Features.Queries;
using MediatR;

namespace Api.Controllers;

[ApiController]
[Route("process")]
public class ProcessController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] GetAllProcessQuery query)
    {
        return Ok(await mediator.Send(query));
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateProcessCommand command)
    {
        return Ok(await mediator.Send(command));
    }
}