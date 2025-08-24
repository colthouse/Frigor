using Frigor.Common.Dtos;

namespace Frigor.Common.Entities;

public class Occurrence
{
    public Guid Uuid { get; set; }
    public bool IsAchieved { get; set; }
    public DateTime Date { get; set; }

    public Habit Habit { get; set; } = null!;
    public Guid HabitUuid { get; set; }

    public static Occurrence FromDto(OccurrenceDto dtoTriggerOccurrence)
    {
        return new Occurrence
        {
            Date = dtoTriggerOccurrence.Date,
            IsAchieved = dtoTriggerOccurrence.IsAchieved,
        };
    }

    public OccurrenceDto ToDto()
    {
        return new OccurrenceDto() { IsAchieved = IsAchieved, Date = Date };
    }
}
