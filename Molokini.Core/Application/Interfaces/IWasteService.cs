using Molokini.Shared.Models;
using Molokini.Shared.Contracts.DTOs;

namespace Molokini.Core.Application.Interfaces;

public interface IWasteService
{
    Task<ServiceResponse<IEnumerable<WasteEntryDto>>> GetAllWasteAsync(PaginationQuery query);
    Task<ServiceResponse<IEnumerable<WasteJobEntryDto>>> GetAllWasteJobsAsync(PaginationQuery query);
    Task<ServiceResponse<WasteJobEntryDto>> GetWasteJobByIdAsync(Guid id);
    Task<ServiceResponse<WasteJobEntryDto>> CreateWasteJobAsync(WasteJobEntryDto newJob);
    Task<ServiceResponse<WasteJobEntryDto>> UpdateWasteJobAsync(Guid id, WasteJobEntryDto updatedJob);
    Task<ServiceResponse<bool>> SoftDeleteWasteJobAsync(Guid id);
    Task<ServiceResponse<bool>> HardDeleteWasteJobAsync(Guid id);
    Task<ServiceResponse<WasteEntryDto>> RemoveWasteEntryAsync(Guid id);
}