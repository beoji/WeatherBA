using Microsoft.EntityFrameworkCore;
using WeatherBA.Shared.Entities;

namespace WeatherBA.Data;
public class SqlForecastRepo : IAsyncRepo<Forecast>
{
    private readonly WeatherContext _context;

    public SqlForecastRepo(WeatherContext context)
    {
        _context = context;
    }
    public Task<List<Forecast>> GetAllAsync()
    {
        return _context.Forecasts.ToListAsync();
    }
    public Task<Forecast> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
    public Task<Forecast> AddAsync(Forecast entity)
    {
        throw new NotImplementedException();
    }
    public Task DeleteAsync(Forecast entity)
    {
        throw new NotImplementedException();
    }
    public Task UpdateAsync(Forecast entity)
    {
        throw new NotImplementedException();
    }
}
