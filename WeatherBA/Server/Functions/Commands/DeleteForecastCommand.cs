using MediatR;
using WeatherBA.Shared.Responses;

namespace WeatherBA.Server.Functions.Commands;
public class DeleteForecastCommand : IRequest<DeleteForecastCommandResponse>
{
    public int Id { get; set; }
}