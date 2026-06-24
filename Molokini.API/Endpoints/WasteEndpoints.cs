using Molokini.Core.Models;
using Molokini.Core.Interfaces;
using Molokini.Shared.DTOs.Requests;
using Microsoft.AspNetCore.Mvc;

public static class WasteEndpoints
{
    public static void MapWasteEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/wastes", async (IWasteService wasteService) =>
        {
            var wastes = await wasteService.GetAllWasteJobsAsync();
            return Results.Ok(wastes);
        });

        app.MapGet("/waste/{id}", async (Guid id, IWasteService wasteService) =>
        {
            var waste = await wasteService.GetWasteJobAsync(id);
            return waste != null ? Results.Ok(waste) : Results.NotFound();
        });

        app.MapPost("/wastes", async ([FromBody] WasteRequestDto request, IWasteRepository repository) =>
        {
            // map to WasteService
        });
    }
}
