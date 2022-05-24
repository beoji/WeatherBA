using AutoMapper;
using WeatherBA.Server.Functions.Commands;
using WeatherBA.Shared.Dtos;
using WeatherBA.Shared.Entities;
using WeatherBA.Shared.Responses;

namespace WeatherBA.Server.Profiles;

public class ForecastProfile : Profile
{
    public ForecastProfile()
    {
        // source -> target
        CreateMap<Forecast, ForecastDto>();
        CreateMap<CreateForecastCommand, Forecast>();

        CreateMap<ForecastDto, CreateForecastCommand>();
        CreateMap<CreateForecastCommandResponse, ForecastDto>();

        CreateMap<UpdateForecastCommand, Forecast>();


    }
}
