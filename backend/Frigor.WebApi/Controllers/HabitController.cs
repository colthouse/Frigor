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
    [HttpGet()]
    public async Task<IActionResult> GetHabits(Guid Uuid)
    {
        List<HabitDto> habitDtos = new List<HabitDto>();
        var habits = await context.Habits.Where(habits => habits.Uuid == Uuid).ToListAsync();
        foreach(var habit in habits)
        {
            if (habit != null)
            {
                habitDtos.Add(habit.ToDto());
            }
        }
        return Ok(habitDtos);
    }

    [HttpPost]
    public async Task<IActionResult> CreateHabit([FromBody] HabitCreationDto habit)
    {
        context.Habits.Add(Habit.FromDto(habit));
        await context.SaveChangesAsync();
        
        return Ok();
    }
}
