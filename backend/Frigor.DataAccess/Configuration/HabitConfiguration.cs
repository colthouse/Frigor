using Frigor.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Frigor.DataAccess.Configuration;

public class HabitConfiguration : IEntityTypeConfiguration<Habit>
{
    public void Configure(EntityTypeBuilder<Habit> builder)
    {
        builder.HasKey(h => h.Uuid);
        builder.HasOne(h => h.Owner)
            .WithMany()
            .HasForeignKey(h => h.OwnerUuid)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(h => h.Godparent)
            .WithMany();
        builder.HasOne(h => h.Trigger)
            .WithMany()
            .HasForeignKey(h => h.TriggerUuid)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
