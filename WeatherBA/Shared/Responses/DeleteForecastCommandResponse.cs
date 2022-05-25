using WeatherBA.Shared.Common;

namespace WeatherBA.Shared.Responses;
public class DeleteForecastCommandResponse : BaseResponse
{
    public DeleteForecastCommandResponse() : base()
    { }
    public DeleteForecastCommandResponse(List<string> validationErrors) 
        : base(validationErrors)
    { }
    //public CreateForecastCommandResponse(ValidationResult validationResult)
    //    : base(validationResult)
    //{ }
    public DeleteForecastCommandResponse(string message)
        : base(message)
    { }

    public DeleteForecastCommandResponse(string message, bool success)
        : base(message, success)
    { }

    public DeleteForecastCommandResponse(int webinarId)
        : base(webinarId)
    { }

}

