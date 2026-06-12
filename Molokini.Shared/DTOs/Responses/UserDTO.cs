public record UserDTO
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string Email { get; set; }
    public bool IsActive { get; set; }
    public bool IsAdmin { get; set; }
    public List<UserRoles> Roles { get; set; }
}
