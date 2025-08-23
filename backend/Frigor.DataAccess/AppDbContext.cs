using EntityFramework.Exceptions.PostgreSQL;
using Frigor.Common.Entities;
using Frigor.Common.Settings;
using Frigor.DataAccess.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Frigor.DataAccess;

public class AppDbContext : DbContext
{
    private readonly IOptions<AppSettings> _options;

    public AppDbContext(IOptions<AppSettings> options)
    {
        _options = options;
    }

    public DbSet<Habit> Habits { get; set; }
    public DbSet<User> User { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseExceptionProcessor();
        optionsBuilder.UseNpgsql(_options.Value.PgConnectionString);
        optionsBuilder.EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new HabitConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
    }
}