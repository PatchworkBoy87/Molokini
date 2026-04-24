using Molokini.Shared.Constants;

namespace Molokini.Shared.Models;

public class ErrorDetails
{
    public string? Code { get; set; }
    public string? Message { get; set; }
    public string? Details { get; set; }
    public int Status { get; set; }

    private ErrorDetails() { }

    public ErrorDetails(string code, string message, string? details = null, int status = 400)
    {
        Code = code;
        Message = message;
        Details = details;
        Status = status;
    }
}