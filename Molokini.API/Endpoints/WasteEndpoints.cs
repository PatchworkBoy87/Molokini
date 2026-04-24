using Molokini.Shared.Contracts.DTOs;
using Molokini.Core.Application.Interfaces;
using Molokini.API.Extensions;

namespace Molokini.API.Endpoints;

public static class WasteEndpoints
{
    public static void MapWasteEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/waste")
            .WithTags("Waste");

        group.MapGet("/", async ([AsParameters] PaginationQuery query, IWasteService wasteService) =>
        {
            var result = (await wasteService.GetAllWasteAsync(query)).ToResult();
            return result;
        })
        .WithName("GetAllWaste")
        .WithSummary("Retrieves a paginated list of waste collection entries.");

        group.MapGet("/jobs", async ([AsParameters] PaginationQuery query, IWasteService wasteService) =>
        {
            var result = (await wasteService.GetAllWasteJobsAsync(query)).ToResult();
            return result;
        })
        .WithName("GetAllWasteJobs")
        .WithSummary("Retrieves a paginated list of waste job collection entries.");

        group.MapGet("/jobs/{id:guid}", async ([AsParameters] Guid id, IWasteService wasteService) =>
        {
            var result = (await wasteService.GetWasteJobByIdAsync(id)).ToResult();
            return result;
        })
        .WithName("GetWasteJobById")
        .WithSummary("Retrieves a single waste job by ID");

        group.MapPost("/jobs/new", async ([AsParameters] WasteJobEntryDto newJob, IWasteService wasteService) =>
        {
            var result = (await wasteService.CreateWasteJobAsync(newJob)).ToResult();
            return result;
        })
        .WithName("AddNewWasteJob")
        .WithSummary("Adds a new waste job to the database");
    }
}