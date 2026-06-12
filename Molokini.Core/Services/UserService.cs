using Molokini.Core.Interfaces;
using Molokini.Core.Models;
using Molokini.Shared.DTOs.Requests;

namespace Molokini.Core.Services
{
    public class UserService : IUserService
    {
        public async Task<IEnumerable<UserDTO>> GetUsersAsync()
        {
            // Get Users code
            await Task.CompletedTask;
            return new List<UserDTO>();
        }

        public async Task<UserDTO> GetUserByIdAsync(Guid id)
        {
            // Get User code
            UserDTO selectedUser = new UserDTO { Id = id, FirstName = "First", LastName = "Person", Email = "person@email.com", IsActive = true, IsAdmin = true };
            await Task.CompletedTask;
            return selectedUser;
        }

        public async Task<UserDTO> CreateUserAsync(CreateUserRequest user)
        {
            // Create User code
            return user;
        }

        public async Task<UserDTO> UpdateUserAsync(UserDTO user)
        {
            // Update User code
            return user;
        }

        public async Task SoftDeleteUserAsync(Guid id)
        {
            // Soft Delete User code
            await Task.CompletedTask;
        }

        public async Task HardDeleteUserAsync(Guid id)
        {
            // Hard Delete User code
            await Task.CompletedTask;
        }
    }
}
