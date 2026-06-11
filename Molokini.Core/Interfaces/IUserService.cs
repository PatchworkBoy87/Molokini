using Molokini.Core.Models;

namespace Molokini.Core.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> GetUserByIdAsync(Guid id);
        Task<User> CreateUserAsync(User user);
        Task<User> UpdateUserAsync(User user);
        Task SoftDeleteUserAsync(Guid id);
        Task HardDeleteUserAsync(Guid id);
    }
}
