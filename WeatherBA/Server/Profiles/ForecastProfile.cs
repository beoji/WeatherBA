using AutoMapper;
using WeatherBA.Server.Functions.Commands;
using WeatherBA.Shared.Dtos;
using WeatherBA.Shared.Entities;

namespace WeatherBA.Server.Profiles;

public class ForecastProfile : Profile
{
    public ForecastProfile()
    {
        // source -> target
        CreateMap<Forecast, ForecastReadDto>();
        CreateMap<CreateForecastCommand, Forecast>();
    }
}
