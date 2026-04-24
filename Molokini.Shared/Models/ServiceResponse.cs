namespace Molokini.Shared.Models;

public class ServiceResponse<T>
{
    public T? Data { get; set; }
    public bool IsSuccess { get; set; }
    public ErrorDetails? Error { get; set; }

    public static ServiceResponse<T> Successful(T data) =>
        new() { IsSuccess = true, Data = data };

    public static ServiceResponse<T> Failed(string code, string message, string? details = null, int status = 400) =>
        new()
        {
            IsSuccess = false,
            Error = new ErrorDetails(code, message, details, status)
        };
}