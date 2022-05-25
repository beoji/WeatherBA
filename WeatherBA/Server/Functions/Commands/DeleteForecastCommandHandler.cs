using MediatR;
using WeatherBA.Data;
using WeatherBA.Shared.Entities;
using WeatherBA.Shared.Responses;

namespace WeatherBA.Server.Functions.Commands;
public class DeleteForecastCommandHandler 
    : IRequestHandler<DeleteForecastCommand, DeleteForecastCommandResponse>
{
    private readonly IAsyncRepo<Forecast> _repo;

    public DeleteForecastCommandHandler(IAsyncRepo<Forecast> repo)
    {
        _repo = repo;
    }

    public async Task<DeleteForecastCommandResponse> Handle(DeleteForecastCommand request,
            CancellationToken cancellationToken)
    {
        var forecast = await _repo.GetByIdAsync(request.Id);

        if (forecast == null)
        {
            return new DeleteForecastCommandResponse("Forecast not found", false);
        }

        _repo.Remove(forecast);

        await _repo.SaveChangesAsync();

        return new DeleteForecastCommandResponse(forecast.Id);
    }
}

