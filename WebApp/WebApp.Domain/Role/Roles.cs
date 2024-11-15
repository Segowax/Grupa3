using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain.Role
{
    public class Roles
    {
        public Roles() { }
        public enum RoleType
        {
            User=1,
            Admin=2,
            Owner=3
        }
    }

   
}
