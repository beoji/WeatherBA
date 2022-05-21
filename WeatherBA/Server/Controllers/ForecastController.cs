using Microsoft.AspNetCore.Mvc;
using WeatherBA.Shared.Dtos;
using WeatherBA.Server.Functions.Query;
using WeatherBA.Shared.Entities;
using MediatR;

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
    public ActionResult<ForecastReadDto> GetForecastById(int id)
    {
        return NotFound();
        //return Ok(_repository.GetByIdAsync(id));
    }
}
