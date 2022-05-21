using WeatherBA.Shared.Entities;

namespace WeatherBA.Data;
public class ForecastRepo : BaseRepo<Forecast>
{
    public ForecastRepo(WeatherContext dbContext) : base(dbContext)
    { }
}

