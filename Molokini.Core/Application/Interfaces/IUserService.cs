using Molokini.Shared.Contracts.DTOs;
using Molokini.Shared.Models;

namespace Molokini.Core.Application.Interfaces;

public interface IUserService
{
    Task<ServiceResponse<IEnumerable<UserDto>>> GetAllUsersAsync(PaginationQuery query);
    Task<ServiceResponse<UserDto>> GetUserByIdAsync(Guid id);
    Task<ServiceResponse<UserDto>> CreateUserAsync(UserDto userDto);
    Task<ServiceResponse<UserDto>> UpdateUserAsync(Guid id, UserDto userDto);
    Task<ServiceResponse<bool>> SoftDeleteUserAsync(Guid id);
    Task<ServiceResponse<bool>> HardDeleteUserAsync(Guid id);
}
