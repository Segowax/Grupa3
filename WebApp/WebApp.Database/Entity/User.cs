using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Database.Entity
{
    internal class User
    {
        private int Id { get; set; }
        private string Nickname { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private string DateCreated { get; set; }

        public User(int id, string nickname, string email, string password, string dateCreated)
        {
            Id = id;
            Nickname = nickname;
            Email = email;
            Password = password;
            DateCreated = dateCreated;
        }

        public User() { }
    }
}
