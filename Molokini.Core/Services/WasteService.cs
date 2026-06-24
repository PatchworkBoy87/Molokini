namespace Molokini.Core.Services;

public class WasteService : IWasteService
{
    public async Task<List<WasteJob>> GetAllWasteJobs()
    {
        List<WasteJob> wasteJobs = new List<WasteJob>();

        return wasteJobs;
    }

    public async Task<List<WasteJob>> GetWasteJobsAsync(Guid customerId)
    {
        List<WasteJob> wasteJobs = new List<WasteJob>();

        return wasteJobs;
    }

    public async Task<WasteJob> GetWasteJobAsync(Guid wasteJobId)
    {
        WasteJob wasteJob = new WasteJob();

        return wasteJob;
    }

    public async Task<WasteJob> CreateWasteJobAsync(CreateWasteJobRequest request)
    {
        WasteJobDTO wasteJobDTO = new WasteJobDTO()
        {
            CustomerId = request.CustomerId,
            WasteType = request.WasteType
        };

        return wasteJob;
    }
}
