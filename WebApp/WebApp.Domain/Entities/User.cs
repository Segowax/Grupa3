using System;
using WebApp.Domain.Role;

namespace WebApp.Domain.Entities
{
    public class User : Base
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public Roles.RoleType Role { get; set; } = Roles.RoleType.User;
        public User(int id, string name, string email, string password, Roles.RoleType role = Roles.RoleType.User)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Role = role;
        }
        public User() { }
    }
}
