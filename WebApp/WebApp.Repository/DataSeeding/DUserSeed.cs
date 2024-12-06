using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain.Entities;
using WebApp.Domain.Role;

namespace WebApp.Repository.DataSeeding
{
    public static class DUserSeed
    {
        public static EntityTypeBuilder<User> UserSeed(this EntityTypeBuilder<User> entityTypeBuilder)
        {
            entityTypeBuilder.HasData(new User()
            {
                Id = 1,
                Name = "test",
                Password = "test",
                Role = Roles.RoleType.User,
                Email = "test@gadshgdsagd.com",
                CreatedDate = DateTime.UtcNow,
            });
            entityTypeBuilder.HasData(new User()
            {
                Id = 2,
                Name = "test",
                Password = "test",
                Role = Roles.RoleType.Admin,
                Email = "test@gadshgdsagd.com",
                CreatedDate = DateTime.UtcNow,
            });
            return entityTypeBuilder;
        }
    }
}
