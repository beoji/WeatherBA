using AutoMapper;
using MediatR;
using WeatherBA.Data;
using WeatherBA.Shared.Dtos;
using WeatherBA.Shared.Entities;

namespace WeatherBA.Server.Functions.Query;

public class GetAllForecastsQueryHandler : IRequestHandler<GetAllForecastsQuery, List<ForecastReadDto>>
{
    private readonly IAsyncRepo<Forecast> _repo;
    private readonly IMapper _mapper;

    public GetAllForecastsQueryHandler(IAsyncRepo<Forecast> repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    public async Task<List<ForecastReadDto>> Handle(GetAllForecastsQuery request, CancellationToken cancellationToken)
    {
        var forecasts = await _repo.GetAllAsync();
        var forecastsOrdered = forecasts.OrderBy(x => x.Date);

        // target <- source
        return _mapper.Map<List<ForecastReadDto>>(forecasts);
    }
}