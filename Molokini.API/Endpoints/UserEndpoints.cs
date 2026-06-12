using Molokini.Core.Models;
using Molokini.Core.Interfaces;
using Molokini.Shared.DTOs.Requests;


namespace Molokini.API.Endpoints
{
    public static class UserEndpoints
    {
        public static void MapUserEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("/users", async (IUserService userService) =>
            {
                var users = await userService.GetUsersAsync();
                return TypedResults.Ok(users);
            })
            .WithName("GetUsers");

            app.MapGet("/users/{id:guid}", async (Guid id, IUserService userService) =>
            {
                var user = await userService.GetUserByIdAsync(id);
                return TypedResults.Ok(user);
            })
            .WithName("GetUserById");

            app.MapPut("/users/{id:guid}", async (Guid id, CreateUserRequest user, IUserService userService) =>
            {
                user.Id = id;
                var updatedUser = await userService.UpdateUserAsync(user);
                return TypedResults.Ok(updatedUser);
            })
            .WithName("UpdateUser");

            app.MapDelete("/users/{id:guid}", async (Guid id, IUserService userService) =>
            {
                await userService.SoftDeleteUserAsync(id);
                return TypedResults.NoContent();
            })
            .WithName("SoftDeleteUser");

            app.MapDelete("/users/hard/{id:guid}", async (Guid id, IUserService userService) =>
            {
                await userService.HardDeleteUserAsync(id);
                return TypedResults.NoContent();
            })
            .WithName("HardDeleteUser");

        }
    }
}
