using WeatherBA.Data;
using WeatherBA.Shared.Entities;

public class MockForecastRepo : IAsyncRepo<Forecast>
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public Task<Forecast> AddAsync(Forecast entity)
    {
        throw new NotImplementedException();
    }

    public void Remove(Forecast entity)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<Forecast>> GetAllAsync()
    {
        //return Enumerable.Range(1, 5).Select(index => new Forecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    }).ToList().AsReadOnly();
        throw new NotImplementedException();
    }

    public Task<Forecast> GetByIdAsync(int id)
    {
        //return new Forecast
        //{
        //    Date = DateTime.Now,
        //    TemperatureC = Random.Shared.Next(-20, 55),
        //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //};
        throw new NotImplementedException();
    }

    public Task<bool> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }

    public void UpdateAsync(Forecast entity)
    {
        throw new NotImplementedException();
    }
}