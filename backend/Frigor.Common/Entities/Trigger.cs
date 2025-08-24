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
}
