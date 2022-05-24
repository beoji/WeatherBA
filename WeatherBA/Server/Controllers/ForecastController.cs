using Microsoft.AspNetCore.Mvc;
using WeatherBA.Shared.Dtos;
using WeatherBA.Shared.Responses;
using WeatherBA.Server.Functions.Query;
using WeatherBA.Server.Functions.Commands;

using MediatR;
using AutoMapper;

namespace WeatherBA.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ForecastController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    public ForecastController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ForecastDto>>> GetAllForecasts()
    {
        var request = new GetAllForecastsQuery();
        var result = await _mediator.Send(request);
        return Ok(result);
    }
     
    [HttpGet("{id}")]
    public async Task<ActionResult<ForecastDto>> GetForecastById(int id)
    {
        var request = new GetForecastByIdQuery() { Id = id };
        var result = await _mediator.Send(request);
        if (result is null)
            return NotFound();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<CreateForecastCommandResponse>> CreateForecast([FromBody] ForecastDto forecastCreateDto)
    {
        var command = _mapper.Map<CreateForecastCommand>(forecastCreateDto);
        var result = await _mediator.Send(command);
        return result;
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<CreateForecastCommandResponse>> UpdateForecast([FromBody] ForecastDto forecastCreateDto)
    {
        var command = _mapper.Map<UpdateForecastCommand>(forecastCreateDto);
        var result = await _mediator.Send(command);
        return result;
    }
}
