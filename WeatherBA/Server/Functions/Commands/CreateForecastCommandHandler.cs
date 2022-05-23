using AutoMapper;
using MediatR;
using WeatherBA.Data;
using WeatherBA.Shared.Entities;
using WeatherBA.Shared.Responses;

namespace WeatherBA.Server.Functions.Commands;
public class CreateForecastCommandHandler 
    : IRequestHandler<CreateForecastCommand, CreateForecastCommandResponse>
{
    private readonly IAsyncRepo<Forecast> _repo;
    private readonly IMapper _mapper;

    public CreateForecastCommandHandler(IAsyncRepo<Forecast> repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }
    public async Task<CreateForecastCommandResponse> Handle(CreateForecastCommand request,
            CancellationToken cancellationToken)
    {
        var validator = new CreateForecastCommandValidator();
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

        var forecast = _mapper.Map<Forecast>(request);
        forecast = await _repo.AddAsync(forecast);

        return new CreateForecastCommandResponse(forecast.Id);
    }
}

