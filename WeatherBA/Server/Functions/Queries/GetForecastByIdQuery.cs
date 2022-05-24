using MediatR;
using WeatherBA.Shared.Dtos;

namespace WeatherBA.Server.Functions.Query;

public class GetForecastByIdQuery : IRequest<ForecastDto>
{
    public int Id { get; set; }
}

