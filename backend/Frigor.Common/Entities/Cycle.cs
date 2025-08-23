using Frigor.Common.Dtos;

namespace Frigor.Common.Entities;

public class Cycle
{
    private Cycle(DateTime startDate, DateTime endDate, List<DayOfWeek> weekdays)
    {
        StartDate = startDate;
        EndDate = endDate;
        Weekdays = weekdays;
    }

    public Cycle()
    {
    }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<DayOfWeek> Weekdays { get; set; }
    public Guid Uuid { get; set; }

    public static Cycle FromDto(CycleDto dtoTriggerCycle)
    {
        return new Cycle(
            dtoTriggerCycle.StartDate,
            dtoTriggerCycle.EndDate,
            dtoTriggerCycle.Weekdays
        );
    }
}