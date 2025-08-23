namespace Frigor.Common.Dtos;

public class HabitDto
{
    private TriggerDto triggerDto;

    public HabitDto(Guid uuid, string name, string description, TriggerDto triggerDto)
    {
        Uuid = uuid;
        Name = name;
        Description = description;
        this.triggerDto = triggerDto;
    }

    public Guid Uuid { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public TriggerDto Trigger { get; set; } = null!;
}
