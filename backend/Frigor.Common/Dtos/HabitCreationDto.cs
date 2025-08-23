namespace Frigor.Common.Dtos;

public class HabitCreationDto
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public TriggerCreationDto Trigger { get; set; } = null!;
}