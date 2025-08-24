using Frigor.Common.Dtos;
using Frigor.Common.Enums;

namespace Frigor.Common.Entities;

public abstract class Trigger
{
    public Guid Uuid { get; set; }
    public TriggerType Type { get; set; }

    public static Trigger FromDto(TriggerDto dto)
    {
        if (dto.Type == TriggerType.Cycle)
        {
            return CycleTrigger.FromDto(dto);
        }
        return HabitTrigger.FromDto(dto);
    }

    public static Trigger FromDto(TriggerCreationDto dto)
    {
        if (dto.Type == TriggerType.Cycle)
        {
            return CycleTrigger.FromDto(dto);
        }
        return HabitTrigger.FromDto(dto);
    }

    public static TriggerDto ToDto(Trigger trigger)
    {
        if (trigger.Type == TriggerType.Habit)
        {
            var habitTrigger = (HabitTrigger)trigger;
            
            return new TriggerDto
            {
                Uuid = trigger.Uuid,
                Type = trigger.Type,
                Habits =  habitTrigger.Habits.Select(Habit.ToDto)
            };
        }

        if (trigger.Type == TriggerType.Cycle)
        {
            var cycleTrigger = (CycleTrigger)trigger;
            
            return new TriggerDto
            {
                Uuid = trigger.Uuid,
                Type = trigger.Type,
                StartDate = cycleTrigger.StartDate,
                EndDate = cycleTrigger.EndDate,
                Weekdays = cycleTrigger.Weekdays,
            };
        }
        
        throw new Exception("Unknown trigger type");
    }
}
