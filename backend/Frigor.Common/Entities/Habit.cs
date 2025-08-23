using Frigor.Common.Dtos;

namespace Frigor.Common.Entities;

public class Habit
{
    public Guid Uuid { get; set; }
    public string Description { get; set; } = null!;
    public string Name { get; set; } = null!;

    public Guid TriggerUuid { get; set; }
    /// <summary>
    /// What does Trigger this Habit?
    /// </summary>
    public Trigger Trigger { get; set; } = null!;

    public Guid OwnerUuid { get; set; }
    public User Owner { get; set; } = null!;

    public Guid GodparentUuid { get; set; }
    public User Godparent { get; set; } = null!;

    /// <summary>
    /// When this Habit is triggered what Triggers are triggered because of it?
    /// </summary>
    public IEnumerable<HabitTrigger> HabitTriggers { get; set; } = new List<HabitTrigger>();

    public IEnumerable<Occurrence> Occurrences { get; set; } = new List<Occurrence>();

    public static Habit FromDto(HabitDto dto)
    {
        var habit = new Habit()
        {
            Name = dto.Name,
            Description = dto.Description,
            Trigger = Trigger.FromDto(dto.Trigger),
        };

        return habit;
    }

    public static Habit FromDto(HabitCreationDto dto)
    {
        var habit = new Habit()
        {
            Name = dto.Name,
            Description = dto.Description,
            GodparentUuid = dto.GodParent,
            OwnerUuid = dto.Owner,
            Trigger = Trigger.FromDto(dto.Trigger),
        };

        return habit;
    }
}
