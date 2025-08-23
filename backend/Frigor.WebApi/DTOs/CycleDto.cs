namespace Frigor.WebApi.DTOs
{
    public class CycleDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<DateOnly> Weekdays { get; set; }
    }
}
