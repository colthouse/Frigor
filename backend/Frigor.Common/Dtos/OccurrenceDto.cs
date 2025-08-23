namespace Frigor.Common.Dtos;

public class OccurrenceDto
{
    public OccurrenceDto(DateTime date, bool isAchieved)
    {
        Date = date;
        IsAchieved = isAchieved;
    }

    public DateTime Date { get; set; }
    public bool IsAchieved { get; set; }
}
