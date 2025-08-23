using Frigor.Common.Entities;
using Frigor.Common.Enums;

namespace Frigor.Common.Dtos;

public class TriggerDto
{
    public TriggerDto(Guid uuid, TriggerType type, OccurrenceDto occurrence, List<Guid> habits)
    {
        Uuid = uuid;
        Type = type;
        Occurrence = occurrence;
        Habits = habits;
    }

    public Guid Uuid  { get; set; }
    public TriggerType Type { get; set; }
    public OccurrenceDto Occurrence { get; set; } = null!;
    public List<Guid> Habits { get; set; } = new();
    public CycleDto Cycle { get; set; }
}
