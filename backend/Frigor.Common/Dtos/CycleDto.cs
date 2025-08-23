namespace Frigor.Common.Dtos;

public class CycleDto
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<DayOfWeek> Weekdays { get; set; } = new List<DayOfWeek>();
}
