using MediatR;
using WeatherBA.Shared.Dtos;

namespace WeatherBA.Server.Functions.Query;

public class GetAllForecastsQuery : IRequest<List<ForecastReadDto>>
{   }