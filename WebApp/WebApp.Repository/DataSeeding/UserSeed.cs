using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp.Domain.Entities;
using WebApp.Domain.Enum;

namespace WebApp.Repository.DataSeeding
{
    public static class UserSeed
    {
        public static EntityTypeBuilder<User> Seed(this EntityTypeBuilder<User> entityTypeBuilder)
        {
            entityTypeBuilder.HasData(new User()
            {
                Id = 1,
                Guid = new Guid("3652ba2e-cdf6-470f-a1fe-4163ff6f59c4"),
                Name = "User",
                Password = "User",
                Role = RoleType.User.ToString(),
                Email = "test@gadshgdsagd.com",
                CreatedDate = new DateTime(2025, 1, 16, 16, 41, 17, 256, DateTimeKind.Utc).AddTicks(6866)
            });

            entityTypeBuilder.HasData(new User()
            {
                Id = 2,
                Guid = new Guid("2b0cc3d5-246c-4993-9cd0-cada8c2324f6"),
                Name = "Admin",
                Password = "Admin",
                Role = RoleType.Admin.ToString(),
                Email = "admin@gadshgdsagd.com",
                CreatedDate = new DateTime(2025, 1, 16, 16, 41, 17, 256, DateTimeKind.Utc).AddTicks(6866)
            });

            return entityTypeBuilder;
        }
    }
}
