using Frigor.Common.Dtos;
using Frigor.Common.Enums;

namespace Frigor.Common.Entities;

public class HabitTrigger : Trigger
{
    public IEnumerable<Habit> Habits { get; set; } = new List<Habit>();

    public static new HabitTrigger FromDto(TriggerDto dto)
    {
        return new HabitTrigger()
        {
            Uuid = dto.Uuid,
            Type = TriggerType.Habit,
            Habits = dto.Habits!.Select(Habit.FromDto),
        };
    }

    public static new HabitTrigger FromDto(TriggerCreationDto dto)
    {
        return new HabitTrigger()
        {
            Type = TriggerType.Habit,
            Habits = dto.Habits!.Select(Habit.FromDto),
        };
    }
}
