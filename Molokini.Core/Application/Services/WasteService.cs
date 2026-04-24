using Molokini.Shared.Contracts.DTOs;
using Molokini.Shared.Models;
using Molokini.Core.Application.Interfaces;

namespace Molokini.Core.Application.Services;

public class WasteService : IWasteService
{
    public Task<ServiceResponse<IEnumerable<WasteEntryDto>>> GetAllWasteAsync(PaginationQuery query)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<IEnumerable<WasteJobEntryDto>>> GetAllWasteJobsAsync(PaginationQuery query)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<WasteJobEntryDto>> GetWasteJobByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<WasteJobEntryDto>> CreateWasteJobAsync(WasteJobEntryDto newJob)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<WasteJobEntryDto>> UpdateWasteJobAsync(Guid id, WasteJobEntryDto updatedJob)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<bool>> SoftDeleteWasteJobAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<bool>> HardDeleteWasteJobAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<WasteEntryDto>> RemoveWasteEntryAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
