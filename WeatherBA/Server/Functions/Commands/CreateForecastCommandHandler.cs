﻿using AutoMapper;
using MediatR;
using WeatherBA.Data;
using WeatherBA.Shared.Entities;

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
            return new CreateForecastCommandResponse(validatorResult);

        var forecast = _mapper.Map<Forecast>(request);

        forecast = await _repo.AddAsync(forecast);

        return new CreateForecastCommandResponse(forecast.Id);
    }
}
