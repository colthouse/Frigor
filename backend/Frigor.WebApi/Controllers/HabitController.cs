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
        var habits = await context.Habits
            .Include(h => h.Occurrences)
            .Include(h => h.Trigger)
            .Where(h => h.OwnerUuid == uuid).ToListAsync();

        return Ok(habits.Select(Habit.ToDto));
    }

    [HttpPost]
    public async Task<IActionResult> CreateHabit([FromBody] HabitCreationDto habit)
    {
        context.Habits.Add(Habit.FromDto(habit));
        await context.SaveChangesAsync();

        return Ok();
    }
    
    // <summary>Get Habits</summary>
    // <return>Habits</return>
    // <response code="200">Successful</response>
    // [HttpGet("{uuid:guid}")]
    // public async Task<IActionResult> GetHabits(Guid uuid)
    // {
    //     var user = await context.User
    //         .FirstOrDefaultAsync(u => u.Uuid == uuid);
    //     if (user == null) return NotFound();

    //     var habits = await context.Habits
    //         .Include(h => h.Trigger)
    //         .ThenInclude(t => t.Occurrence)
    //         .Where(h => user.Habits.Contains(h.Uuid)).ToListAsync();

    //     return Ok(habits);
    // }

    // [HttpPost("{uuid:guid}")]
    // public async Task<IActionResult> CreateHabit(Guid uuid, [FromBody] HabitCreationDto habitDto)
    // {
    //     Habit habit = Habit.FromDto(habitDto);
    //     context.Habits.Add(habit);
    //     User? user = await context.User.FirstOrDefaultAsync(u => u.Uuid == uuid);

    //     if (user == null)
    //         return NotFound();

    //     user.Habits.Add(habit.Uuid);
    //     await context.SaveChangesAsync();

    //     return Ok();
    // }

    [HttpDelete("{uuid:guid}")]
    public async Task<IActionResult> DeleteHabit(Guid uuid)
    {
        context.Habits.Remove(context.Habits.First(h => h.Uuid == uuid));
        await context.SaveChangesAsync();
        
        return Ok();
    }
    
    [HttpGet("{uuid:guid}/{achieved:bool}")]
    public async Task<IActionResult> AchieveHabit(Guid uuid,  bool achieved)
    {
        var habit = await context.Habits
            .Include(h => h.Occurrences)
            .FirstAsync(habit => habit.Uuid== uuid);

        var occurrence = habit.Occurrences.FirstOrDefault(o => o.Date.Date == DateTime.Now.Date);
        if (occurrence != null)
        {
            occurrence.IsAchieved = achieved;
        }
        else
        {
            var con = new Occurrence
            {
                Habit = habit,
                Date = DateTimeOffset.Now.UtcDateTime,
                IsAchieved = achieved
            };

            context.Occurrence.Add(con);
            var occurrencesList = habit.Occurrences.ToList() ;
            occurrencesList.Add(con);

            habit.Occurrences = occurrencesList;
        }
        await context.SaveChangesAsync();

        return Ok();
    }
}
