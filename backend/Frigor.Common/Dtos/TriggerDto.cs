using Frigor.Common.Entities;
using Frigor.Common.Enums;

namespace Frigor.Common.Dtos;

public class TriggerDto
{
    private Occurrence occurrence;
    private OccurrenceDto occurrenceDto;

    public TriggerDto(Guid uuid, TriggerType type, Occurrence occurrence, List<Guid> habits)
    {
        Uuid = uuid;
        Type = type;
        this.occurrence = occurrence;
        Habits = habits;
    }

    public TriggerDto(Guid uuid, TriggerType type, OccurrenceDto occurrenceDto, List<Guid> habits)
    {
        Uuid = uuid;
        Type = type;
        this.occurrenceDto = occurrenceDto;
        Habits = habits;
    }

    public Guid Uuid  { get; set; }
    public TriggerType Type { get; set; }
    public OccurrenceDto Occurrence { get; set; } = null!;
    public List<Guid> Habits { get; set; } = new();
}
