using Microsoft.AspNetCore.Mvc;
using WeatherBA.Shared.Dtos;
using WeatherBA.Server.Functions.Query;
using WeatherBA.Server.Functions.Commands;
using MediatR;
using System.Diagnostics;

namespace WeatherBA.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ForecastController : ControllerBase
{
    private readonly IMediator _mediator;
    public ForecastController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ForecastReadDto>>> GetAllForecasts()
    {
        var request = new GetAllForecastsQuery();
        var result = await _mediator.Send(request);
        return Ok(result);
    }
     
    [HttpGet("{id}")]
    public async Task<ActionResult<ForecastReadDto>> GetForecastById(int id)
    {
        var request = new GetForecastByIdQuery() { Id = id };
        var result = await _mediator.Send(request);
        if (result is null)
            return NotFound();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<CreateForecastCommandResponse>> CreateForecast([FromBody] CreateForecastCommand createForecastCommand)
    {
        var result = await _mediator.Send(createForecastCommand);
        Console.WriteLine(result.ValidationErrors);
        Console.WriteLine(result.Message);
        Console.WriteLine(result.Status);
        Console.WriteLine(result.Success);
        return result;
    }
}
