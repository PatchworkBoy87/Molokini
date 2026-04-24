using Molokini.Shared.Contracts.DTOs;
using Molokini.Shared.Models;
using Molokini.Core.Application.Interfaces;

namespace Molokini.Core.Application.Services;

public class UserService : IUserService
{
    public Task<ServiceResponse<IEnumerable<UserDto>>> GetAllUsersAsync(PaginationQuery query)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<UserDto>> GetUserByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    Task<ServiceResponse<UserDto>> CreateUserAsync(UserDto userDto)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<UserDto>> UpdateUserAsync(Guid id, UserDto userDto)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<bool>> SoftDeleteUserAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<bool>> HardDeleteUserAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    Task<ServiceResponse<UserDto>> IUserService.CreateUserAsync(UserDto userDto)
    {
        return CreateUserAsync(userDto);
    }
}
