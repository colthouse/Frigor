using Frigor.Common.Dtos;
using Frigor.Common.Entities;
using Frigor.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace Frigor.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HabitController(AppDbContext context): ControllerBase
{
    /// <summary>Get Habits</summary>
    /// <return>Habits</return>
    /// <response code="200">Successful</response>
    [HttpGet()]
    public async Task<IActionResult> GetHabits()
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> CreateHabit([FromBody] HabitDto habit)
    {
        context.Habits.Add(Habit.FromDto(habit));
        await context.SaveChangesAsync();
        
        return Ok();
    }
}
