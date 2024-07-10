using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("process")]
public class ProcessController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetByIdAsync()
    {
        return Ok("ok");
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync()
    {
        return Ok("ok");
    }
}