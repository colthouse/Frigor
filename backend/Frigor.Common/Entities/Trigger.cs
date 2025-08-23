using Frigor.Common.Dtos;
using Frigor.Common.Enums;

namespace Frigor.Common.Entities;

public class Trigger
{
    private Trigger(Guid uuid, TriggerType type, Occurrence occurrence, List<Guid> habits, Cycle cycle)
    {
        Uuid = uuid;
        Type = type;
        Habits = habits;
        Cycle = cycle;
        Occurrence = occurrence;
    }

    private Trigger(TriggerType type, Occurrence occurrence, List<Guid> habits, Cycle cycle)
    {
        Type = type;
        Habits = habits;
        Occurrence = occurrence;
        Cycle = cycle;
    }

    public Trigger()
    {
    }

    public Guid Uuid { get; set; }
    public TriggerType Type { get; set; }
    public Occurrence Occurrence { get; set; }
    public List<Guid> Habits { get; set; }
    public Cycle Cycle { get; set; }


    internal static Trigger FromDto(TriggerDto dtoTrigger)
    {
        return new Trigger(dtoTrigger.Uuid, dtoTrigger.Type, Occurrence.FromDto(dtoTrigger.Occurrence),
            dtoTrigger.Habits, Cycle.FromDto(dtoTrigger.Cycle));
    }

    public static Trigger FromDto(TriggerCreationDto dtoTrigger)
    {
        return new Trigger(dtoTrigger.Type, Occurrence.FromDto(dtoTrigger.Occurrence), dtoTrigger.Habits,
            Cycle.FromDto(dtoTrigger.Cycle));
    }

    public TriggerDto ToDto()
    {
        return new TriggerDto(Uuid, Type, Occurrence.ToDto(), Habits);
    }
}