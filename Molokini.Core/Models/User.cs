namespace Molokini.Core.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; } // needs to be Required, can't be null
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public List<UserRoles> Roles { get; set; }
        public string PasswordHash { get; set; }
    }
}
