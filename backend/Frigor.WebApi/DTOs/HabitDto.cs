using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Frigor.WebApi.DTOs
{
    public class HabitDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TriggerDto Trigger { get; set; }
        public CycleDto Cycle { get; set; }
    }
}
