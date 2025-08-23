using Frigor.Common.Enums;

namespace Frigor.Common.Dtos;

public class TriggerCreationDto
{
    public TriggerType Type { get; set; }
    public OccurrenceDto Occurrence { get; set; } = null!;
    public List<Guid> Habits { get; set; } = new();
}