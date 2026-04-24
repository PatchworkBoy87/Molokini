using Molokini.Shared.Models;

namespace Molokini.API.Extensions;

public static class ResultExtensions
{
    public static IResult ToResult<T>(this ServiceResponse<T> response)
    {
        return response.IsSuccess
            ? Results.Ok(response.Data)
            : Results.Json(response.Error, statusCode: response.Error?.Status ?? 400);
    }
}