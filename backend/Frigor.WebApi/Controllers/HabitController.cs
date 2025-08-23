using Microsoft.AspNetCore.Mvc;

namespace Frigor.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HabitController : ControllerBase
{
    /// <summary>Get Habits</summary>
    /// <return>Habits</return>
    /// <response code="200">Successful</response>
    [HttpGet()]
    public async Task<IActionResult> GetHabits()
    {
        return Ok();
    }
}
