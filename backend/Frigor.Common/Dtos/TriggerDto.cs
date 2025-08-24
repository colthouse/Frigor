using Frigor.Common.Enums;

namespace Frigor.Common.Dtos;

public class TriggerDto
{
    public Guid Uuid  { get; set; }
    public TriggerType Type { get; set; }
    public IEnumerable<HabitDto>? Habits { get; set; } = new List<HabitDto>();
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public List<DayOfWeek> Weekdays { get; set; } = new List<DayOfWeek>();
}
