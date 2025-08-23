namespace Frigor.WebApi.DTOs
{
    public class TriggerDto
    {
        public int Id { get; set; }
        public TriggerTypeEnum Type { get; set; }
        public OccurrenceDto Occurrence { get; set; }

    }

    public enum TriggerTypeEnum
    {
        Cycle = 0,
        Habit = 1
    }
}
