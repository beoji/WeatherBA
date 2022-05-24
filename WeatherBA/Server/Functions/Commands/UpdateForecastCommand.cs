using MediatR;
using WeatherBA.Shared.Responses;

namespace WeatherBA.Server.Functions.Commands;
public class UpdateForecastCommand : IRequest<CreateForecastCommandResponse>
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int TemperatureC { get; set; }
    public string? Summary { get; set; }
}
