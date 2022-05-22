using Microsoft.EntityFrameworkCore;
using WeatherBA.Shared.Common;
using WeatherBA.Shared.Entities;

namespace WeatherBA.Data;
public class WeatherContext : DbContext
{
    public WeatherContext(DbContextOptions<WeatherContext> opt) : base(opt)
    {    }
    
    public DbSet<Forecast> Forecasts { get; set; }
    
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreateDate = DateTime.Now;
                    break;
                case EntityState.Modified:
                    entry.Entity.LastModifiedDate = DateTime.Now;
                    break;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }
}