using Molokini.Core.Models;
using Molokini.Core.Services;
using Molokini.Core.Interfaces;

namespace Molokini.API.Endpoints
{
    public static class UserEndpoints
    {
        public static void MapUserEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("/users", async (IUserService userService) =>
            {
                var users = await userService.GetUsersAsync();
                return Results.Ok(users);
            })
            .WithName("GetUsers");

            app.MapGet("/users/{id:guid}", async (Guid id, IUserService userService) =>
            {
                var user = await userService.GetUserByIdAsync(id);
                return Results.Ok(user);
            })
            .WithName("GetUserById");

            app.MapPut("/users/{id:guid}", async (Guid id, User user, IUserService userService) =>
            {
                user.Id = id;
                var updatedUser = await userService.UpdateUserAsync(user);
                return Results.Ok(updatedUser);
            })
            .WithName("UpdateUser");

            app.MapDelete("/users/{id:guid}", async (Guid id, IUserService userService) =>
            {
                await userService.SoftDeleteUserAsync(id);
                return Results.NoContent();
            })
            .WithName("SoftDeleteUser");

            app.MapDelete("/users/hard/{id:guid}", async (Guid id, IUserService userService) =>
            {
                await userService.HardDeleteUserAsync(id);
                return Results.NoContent();
            })
            .WithName("HardDeleteUser");

        }
    }
}
