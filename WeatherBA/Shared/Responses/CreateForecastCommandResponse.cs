using WeatherBA.Shared.Common;

namespace WeatherBA.Shared.Responses;
public class CreateForecastCommandResponse : BaseResponse
{
    public int? Id { get; set; }

    public CreateForecastCommandResponse() : base()
    { }
    public CreateForecastCommandResponse(List<string> validationErrors) 
        : base(validationErrors)
    { }
    //public CreateForecastCommandResponse(ValidationResult validationResult)
    //    : base(validationResult)
    //{ }
    public CreateForecastCommandResponse(string message)
        : base(message)
    { }

    public CreateForecastCommandResponse(string message, bool success)
        : base(message, success)
    { }

    public CreateForecastCommandResponse(int webinarId)
    {
        Id = webinarId;
    }

}

