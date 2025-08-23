using Frigor.Common.Enums;

namespace Frigor.Common.Dtos;

public class TriggerDto
{
    public Guid Uuid  { get; set; }
    public TriggerType Type { get; set; }
    public OccurrenceDto Occurrence { get; set; } = null!;
}
