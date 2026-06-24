using Molokini.Core.DTOs;
using Molokini.Core.Entities;

namespace Molokini.Infrastructure.Repositories;

public class UserRepository
{
    public async List<User> GetUsersAsync()
    {
        // List<User> = await _context.Users.ToListAsync();
        List<User> users = new List<User>();

        return users;
    }

    public async User GetUserByIdAsync(Guid id)
    {
        // User user = await _context.Users.FindAsync(id);
        User user = new User();

        return user;
    }

    public async Task<User> CreateUserAsync(UserDTO user)
    {
        var newUser = new User()
        {
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            Password = user.Password,
            Roles = user.Roles
        };

        // _context.Users.Add(newUser);
        // await _context.SaveChangesAsync();

        return user;
    }

    public async Task<User> UpdateUserAsync(UserDTO user)
    {
        var updatedUser = new User()
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            Password = user.Password,
            Roles = user.Roles
        };

        // _context.Users.Update(updatedUser);
        // await _context.SaveChangesAsync();

        return user;
    }

    public async Task<User> SoftDeleteUserAsync(Guid id)
    {
        User user = await GetUserByIdAsync(id);
        user.IsDeleted = true;
        await UpdateUserAsync(user);

        return user;
    }

    public async Task<User> HardDeleteUserAsync(Guid id)
    {
        // User user = await _context.Users.FindAsync(id);
        // _context.Users.Remove(user);
        // await _context.SaveChangesAsync();

        return new User();
    }
}
