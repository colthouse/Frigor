using Frigor.Common.Dtos;
using System.Runtime.CompilerServices;

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

    public OccurrenceDto ToDto()
    {
        return new OccurrenceDto(Date,IsAchieved);
    }

    public Guid Uuid { get; set; }

    public bool IsAchieved { get; set; }

    public DateTime Date { get; set; }
}
