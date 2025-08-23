using Frigor.Common.Dtos;

namespace Frigor.Common.Entities;

public class Occurrence
{
    public Occurrence()
    {
    }

    public static Occurrence FromDto(OccurrenceDto dtoTriggerOccurrence)
    {
        return new Occurrence
        {
            Date = dtoTriggerOccurrence.Date,
            IsAchieved = dtoTriggerOccurrence.IsAchieved,
        };
    }

    public bool IsAchieved { get; set; }

    public DateTime Date { get; set; }
}