using Microsoft.EntityFrameworkCore;
using WeatherBA.Shared.Entities;

namespace WeatherBA.Data;
public class WeatherContext : DbContext
{
    public WeatherContext(DbContextOptions<WeatherContext> opt) : base(opt)
    {    }
    
    public DbSet<Forecast> Forecasts { get; set; }
}