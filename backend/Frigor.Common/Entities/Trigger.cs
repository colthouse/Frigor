using Frigor.Common.Dtos;
using Frigor.Common.Enums;

namespace Frigor.Common.Entities;

public class Trigger
{
    public Guid Uuid  { get; set; }
    public TriggerType Type { get; set; }
    public Occurrence Occurrence { get; set; } = null!;
    public List<Guid> Habits { get; set; } = new();

    internal static Trigger FromDto(TriggerDto dtoTrigger)
    {
        return new Trigger
        {
            Uuid = dtoTrigger.Uuid,
            Type = dtoTrigger.Type,
            Occurrence = Occurrence.FromDto(dtoTrigger.Occurrence)
        };
    }
}