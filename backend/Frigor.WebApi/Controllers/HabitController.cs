using Frigor.Common.Dtos;
using Frigor.Common.Entities;
using Frigor.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Frigor.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HabitController(AppDbContext context): ControllerBase
{
    /// <summary>Get Habits</summary>
    /// <return>Habits</return>
    /// <response code="200">Successful</response>
    [HttpGet("{uuid:guid}")]
    public async Task<IActionResult> GetHabits(Guid uuid)
    {
        var user = await context.User.FirstOrDefaultAsync(u => u.Uuid == uuid);
        if (user == null) return NotFound();
        
        var habits = await context.Habits.Where(h => user.Habits.Contains(h.Uuid)).ToListAsync();
        
        return Ok(habits);
    }

    [HttpPost("{uuid:guid}")]
    public async Task<IActionResult> CreateHabit(Guid uuid, [FromBody] HabitCreationDto habit)
    {
        var createdHabit = context.Habits.Add(Habit.FromDto(habit));
        var user = context.User.FirstOrDefault(u => u.Uuid == uuid);
        user.Habits.Add(createdHabit.Entity.Uuid);
        await context.SaveChangesAsync();
        
        return Ok();
    }
}
