using WebApp.Domain.Enum;

namespace WebApp.Domain.Entities
{
    public class User : Base
    {   
        public required string Email { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Adress { get; set; }
        public required string Password { get; set; }
        
        public string Role { get; set; } = RoleType.User.ToString();
    }
}
