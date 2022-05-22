using System.ComponentModel.DataAnnotations;

namespace WeatherBA.Server.Functions;
public class BaseResponse
{
    public ResponseStatus Status { get; set; }
    public bool Success { get; set; }
    public string? Message { get; set; }
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
    Success = 0,
    NotFound = 1,
    BadQuery = 2,
    ValidationError = 3
}
