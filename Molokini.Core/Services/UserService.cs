using Molokini.Core.Interfaces;
using Molokini.Core.Models;

namespace Molokini.Core.Services
{
    public class UserService : IUserService
    {
        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            // Get Users code
            await Task.CompletedTask;
            return new List<User>();
        }

        public async Task<User> GetUserByIdAsync(Guid id)
        {
            // Get User code
            User selectedUser = new User { Id = id, FirstName = "First", LastName = "Person", Email = "person@email.com", IsActive = true };
            await Task.CompletedTask;
            return selectedUser;
        }

        public async Task<User> CreateUserAsync(User user)
        {
            // Create User code
            return user;
        }

        public async Task<User> UpdateUserAsync(User user)
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
