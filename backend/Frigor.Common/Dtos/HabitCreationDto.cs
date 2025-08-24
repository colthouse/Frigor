namespace Frigor.Common.Dtos;

public class HabitCreationDto
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public TriggerDto Trigger { get; set; } = null!;
    public Guid Owner {get; set; }
    public Guid GodParent {get; set; }
}
