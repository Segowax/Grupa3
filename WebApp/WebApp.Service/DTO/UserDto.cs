using WebApp.Domain.Enum;

namespace WebApp.Service.DTO
{
    public class UserDto
    {
        public required string FirstName { get; set; }

        public required string LastName { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Email { get; set; }
        public string? Adress { get; set; }
        public required string Password { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Role { get; set; } = RoleType.User.ToString();
    }
}
