using Microsoft.EntityFrameworkCore;
using WebApp.Domain.Entities;

namespace WebApp.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        DbSet<Lokale> Lokale { get; set; }
        DbSet<Dania> Dania { get; set; }
        DbSet<Pracownicy> Pracownicy{ get; set; }
        DbSet<Rezerwacje> Rezerwacje { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
