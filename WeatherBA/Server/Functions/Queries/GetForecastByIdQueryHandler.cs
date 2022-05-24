using AutoMapper;
using MediatR;
using WeatherBA.Data;
using WeatherBA.Shared.Dtos;
using WeatherBA.Shared.Entities;

namespace WeatherBA.Server.Functions.Query;

public class GetForecastByIdQueryHandler : IRequestHandler<GetForecastByIdQuery, ForecastDto>
{
    private readonly IAsyncRepo<Forecast> _repo;
    private readonly IMapper _mapper;

    public GetForecastByIdQueryHandler(IAsyncRepo<Forecast> repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    public async Task<ForecastDto> Handle(GetForecastByIdQuery request, CancellationToken cancellationToken)
    {
        var forecast = await _repo.GetByIdAsync(request.Id);
        // target <- source
        return _mapper.Map<ForecastDto>(forecast);
    }
}