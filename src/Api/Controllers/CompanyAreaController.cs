using Microsoft.AspNetCore.Mvc;
using MediatR;
using CaseProcess.Application.Features.Commands;

namespace Api.Controllers;

[ApiController]
[Route("company-area")]
public class CompanyAreaController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetByIdAsync()
    {
        return Ok("ok");
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        return Ok("ok");
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateCompanyAreaCommand command)
    {
        return Ok(await mediator.Send(command));
    }
}

