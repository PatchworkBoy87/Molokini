using Molokini.Core.Interfaces;
using Molokini.Core.Models;
using Molokini.Shared.DTOs.Requests;
using Molokini.Infrastructure.Repositories;

namespace Molokini.Core.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<UserDTO>> GetUsersAsync()
        {
            List<User> users = await _userRepository.GetUsersAsync();

            var userDTOs = users.Select(u => new UserDTO
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Email = u.Email,
                IsActive = u.IsActive,
                IsAdmin = u.IsAdmin
            });

            await Task.CompletedTask;
            return userDTOs;
        }

        public async Task<UserDTO> GetUserByIdAsync(Guid id)
        {
            User user = await _userRepository.GetUserByIdAsync(id);

            UserDTO selectedUser = new UserDTO
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                IsActive = user.IsActive,
                IsAdmin = user.IsAdmin
            };

            return selectedUser;
        }

        public async Task<UserDTO> CreateUserAsync(CreateUserRequest user)
        {
            var newUser = new UserDTO()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Password = user.Password,
                Roles = user.Roles
            };

            var createdUser = await _userRepository.CreateUserAsync(newUser);

            return newUser;
        }

        public async Task<UserDTO> UpdateUserAsync(UpdateUserRequest user)
        {
            var updatedUser = new UserDTO()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Password = user.Password,
                Roles = user.Roles
            };

            var updatedUser = await _userRepository.UpdateUserAsync(updatedUser);

            return updatedUser;
        }

        public async Task SoftDeleteUserAsync(Guid id)
        {
            await _userRepository.SoftDeleteUserAsync(id);
            await Task.CompletedTask;
        }

        public async Task HardDeleteUserAsync(Guid id)
        {
            await _userRepository.HardDeleteUserAsync(id);
            await Task.CompletedTask;
        }
    }
}
