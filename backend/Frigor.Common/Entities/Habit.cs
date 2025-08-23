using System.Runtime.CompilerServices;
using Frigor.Common.Dtos;

namespace Frigor.Common.Entities;

public class Habit
{
    private Habit(Guid uuid, string name, string description, Trigger trigger)
    {
        Uuid = uuid;
        Name = name;
        Description = description;
        Trigger = trigger;
    }

    private Habit(string name, string description, Trigger trigger)
    {
        Name = name;
        Description = description;
        Trigger = trigger;
    }

    public Habit()
    {
    }

    public Guid Uuid { get; set; }

    public static Habit FromDto(HabitDto dto)
    {
        var habit = new Habit(
            dto.Uuid,
             dto.Name,
             dto.Description,
            Trigger.FromDto(dto.Trigger)
        );

        return habit;
    }

    public Trigger Trigger { get; set; }

    public string Description { get; set; }

    public string Name { get; set; }

    public static Habit FromDto(HabitCreationDto dto)
    {
        var habit = new Habit(
            dto.Name,
            dto.Description,
            Trigger.FromDto(dto.Trigger)
        );

        return habit;
    }
}