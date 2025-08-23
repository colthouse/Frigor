using Frigor.Common.Entities;
using Frigor.Common.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Frigor.DataAccess.Configuration;

public class TriggerConfiguration : IEntityTypeConfiguration<Trigger>
{
    public void Configure(EntityTypeBuilder<Trigger> builder)
    {
        builder.HasKey(e => e.Uuid);
        builder
            .HasDiscriminator(t => t.Type)
            .HasValue<HabitTrigger>(TriggerType.Habit)
            .HasValue<CycleTrigger>(TriggerType.Cycle);
    }
}
