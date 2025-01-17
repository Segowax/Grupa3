using Microsoft.EntityFrameworkCore;
using WebApp.Domain.Entities;
using WebApp.Repository.DataSeeding;

namespace WebApp.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        DbSet<User> Users { get; set; }

        DbSet<Schedule> Schedules { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Seed();

            base.OnModelCreating(modelBuilder);
        }
    }
}
