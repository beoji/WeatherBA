using FluentValidation;

namespace WeatherBA.Server.Functions.Commands;

public class UpdateForecastCommandValidator : AbstractValidator<UpdateForecastCommand>
{
    public UpdateForecastCommandValidator()
    {
        RuleFor(w => w.Date).NotEmpty().NotNull();
        RuleFor(w => w.TemperatureC).NotEmpty().NotNull();
    }
}

