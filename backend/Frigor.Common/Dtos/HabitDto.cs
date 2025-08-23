namespace Frigor.Common.Dtos;

public class HabitDto
{
    public Guid Uuid { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public TriggerDto Trigger { get; set; } = null!;
    public CycleDto Cycle { get; set; } = null!;
}
