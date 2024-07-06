using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("company-area")]
public class CompanyAreaController : ControllerBase
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
    public async Task<IActionResult> CreateAsync()
    {
        return Ok("ok");
    }
}

