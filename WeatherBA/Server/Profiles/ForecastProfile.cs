using AutoMapper;
using WeatherBA.Shared.Dtos;
using WeatherBA.Shared.Entities;

namespace WeatherBA.Server.Profiles;

public class ForecastProfile : Profile
{
    public ForecastProfile()
    {
        // source -> target
        CreateMap<Forecast, ForecastReadDto>();
    }
}
