using EntityFramework.Exceptions.PostgreSQL;
using Frigor.Common.Entities;
using Frigor.Common.Settings;
using Frigor.DataAccess.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Frigor.DataAccess;

public class AppDbContext(IOptions<AppSettings> options) : DbContext
{
    public DbSet<Habit> Habits { get; set; } = null!;
    public DbSet<User> User { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseExceptionProcessor();
        optionsBuilder.UseNpgsql(options.Value.PgConnectionString);
        optionsBuilder.EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new HabitConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
    }
}
