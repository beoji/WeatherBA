using System.ComponentModel.DataAnnotations;

namespace WeatherBA.Shared.Responses;
public class BaseResponse
{
    public int Id { get; set; } = -1;
    public ResponseStatus Status { get; set; } = ResponseStatus.Null;
    public bool? Success { get; set; } = null;
    public string? Message { get; set; } = String.Empty;
    public List<string> ValidationErrors { get; set; } = new List<string>();

    public BaseResponse()
    {
        Success = true;
    }
    public BaseResponse(string message = null)
    {
        Success = true;
        Message = message;
    }

    public BaseResponse(string message, bool success)
    {
        Success = success;
        Message = message;
    }

    public BaseResponse(List<string> validationErrors)
    {
        ValidationErrors = validationErrors;
        Status = ResponseStatus.ValidationError;
        Success = false;
    }
    
    public BaseResponse(int forecastId)
    {
        Id = forecastId;
        Status = ResponseStatus.Success;
        Success = true;
    }

    //public BaseResponse(ValidationResult validatorResult)
    //{
    //    var validationErrors = new List<string>();
    //    var success = validatorResult.Errors.count < 0;
    //    foreach (var item in validatorResult.Errors)
    //        ValidationErrors.Add(item.ErrorMessage);
    // Nie działa validatorResult nie ma atrybutu Errors
    //}
}
public enum ResponseStatus
{
    Null = -1,
    Success = 0,
    NotFound = 1,
    BadQuery = 2,
    ValidationError = 3
}
