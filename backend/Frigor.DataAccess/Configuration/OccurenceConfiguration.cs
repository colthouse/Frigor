using Frigor.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Frigor.DataAccess.Configuration;

public class OccurenceConfiguration : IEntityTypeConfiguration<Occurrence>
{
    public void Configure(EntityTypeBuilder<Occurrence> builder)
    {
        builder.HasKey(h => h.Uuid);
        builder.HasOne(o => o.Habit)
            .WithMany(t => t.Occurrences)
            .HasForeignKey(o => o.HabitUuid)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
