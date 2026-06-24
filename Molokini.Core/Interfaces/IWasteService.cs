using Molokini.Core.Models;
using Molokini.Shared.DTOs.Requests;

namespace Molokini.Core.Interfaces
{
    public interface IWasteService
    {
        Task<List<WasteJob>> GetAllWasteJobsAsync();
        Task<List<WasteJob>> GetWasteJobsAsync(Guid customerId);
        Task<WasteJob> GetWasteJobAsync(Guid wasteJobId);
        Task<WasteJob> CreateWasteJobAsync(WasteJobRequestDto request);
    }
}
