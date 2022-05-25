using AutoMapper;
using MediatR;
using WeatherBA.Data;
using WeatherBA.Shared.Dtos;
using WeatherBA.Shared.Entities;
using WeatherBA.Shared.Responses;

namespace WeatherBA.Server.Functions.Commands;
public class UpdateForecastCommandHandler 
    : IRequestHandler<UpdateForecastCommand, CreateForecastCommandResponse>
{
    private readonly IAsyncRepo<Forecast> _repo;
    private readonly IMapper _mapper;

    public UpdateForecastCommandHandler(IAsyncRepo<Forecast> repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }
    public async Task<CreateForecastCommandResponse> Handle(UpdateForecastCommand request,
            CancellationToken cancellationToken)
    {
        var validator = new UpdateForecastCommandValidator();
        var validatorResult = await validator.ValidateAsync(request);

        if (!validatorResult.IsValid)
        {
            var errorList = new List<string>();
            foreach(var item in validatorResult.Errors)
            {
                errorList.Add(item.ErrorMessage);
            }
            return new CreateForecastCommandResponse(errorList);
        }

        var forecast = await _repo.GetByIdAsync(request.Id);
        _mapper.Map(request, forecast);

        await _repo.SaveChangesAsync();

        return new CreateForecastCommandResponse(forecast.Id);
    }
}

