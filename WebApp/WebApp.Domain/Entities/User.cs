﻿using WebApp.Domain.Enum;

namespace WebApp.Domain.Entities
{
    public class User : Base
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Role { get; set; } = RoleType.User.ToString();
    }
}
