namespace WeatherBA.Shared.Dtos;
public class ForecastDto
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int TemperatureC { get; set; }
    public string? Summary { get; set; }
}