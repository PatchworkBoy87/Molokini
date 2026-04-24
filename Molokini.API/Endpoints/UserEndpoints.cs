using Molokini.Shared.Contracts.DTOs;
using Molokini.Core.Application.Interfaces;
using Molokini.API.Extensions;

namespace Molokini.API.Endpoints;

public static class UserEndpoints
{
    public static void MapUserEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/users")
            .WithTags("User");

        group.MapGet("/", async ([AsParameters] PaginationQuery query, IUserService userService) =>
            {
                var result = (await userService.GetAllUsersAsync(query)).ToResult();
                return result;
            })
            .WithName("GetAllUsers")
            .WithSummary("Retrieves a paginated list of users");

        group.MapGet("/{id:guid}", async ([AsParameters] Guid id, IUserService userService) =>
            {
                var result = (await userService.GetUserByIdAsync(id)).ToResult();
                return result;
            })
            .WithName("GetUserById")
            .WithSummary("Retrieves a user by their ID");
    }
}
