namespace Frigor.Common.Dtos;

public class HabitCreationDto
{
    public Guid Uuid { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public TriggerDto Trigger { get; set; } = null!;
}
