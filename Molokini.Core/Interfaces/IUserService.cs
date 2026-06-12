using Molokini.Core.Models;

namespace Molokini.Core.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetUsersAsync();
        Task<UserDTO> GetUserByIdAsync(Guid id);
        Task<UserDTO> CreateUserAsync(CreateUserRequest user);
        Task<UserDTO> UpdateUserAsync(UserDTO user);
        Task SoftDeleteUserAsync(Guid id);
        Task HardDeleteUserAsync(Guid id);
    }
}
