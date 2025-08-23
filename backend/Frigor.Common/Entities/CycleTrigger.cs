using Frigor.Common.Dtos;
using Frigor.Common.Enums;

namespace Frigor.Common.Entities;

public class CycleTrigger : Trigger
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<DayOfWeek> Weekdays { get; set; } = new List<DayOfWeek>();

    public static new CycleTrigger FromDto(TriggerDto dto)
    {
        return new CycleTrigger()
        {
            Uuid = dto.Uuid,
            Type = TriggerType.Cycle,
            StartDate = dto.StartDate!.Value,
            EndDate = dto.EndDate!.Value,
            Weekdays = dto.Weekdays,
        };
    }

    public static new CycleTrigger FromDto(TriggerCreationDto dto)
    {
        return new CycleTrigger()
        {
            Type = TriggerType.Cycle,
            StartDate = dto.StartDate,
            EndDate = dto.EndDate,
            Weekdays = dto.Weekdays,
        };
    }
}
