namespace WeatherBA.Server.Functions.Commands;

public class CreateForecastCommandValidator : AbstractValidator<CreateForecastCommand>
{
    public CreateForecastCommandValidator()
    {
        RuleFor(w => w.Date).NotEmpty().NotNull();
        RuleFor(w => w.TemperatureC).NotEmpty().NotNull();
    }
}

