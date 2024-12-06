using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain.Entities;
using WebApp.Repository.DataSeeding;

namespace WebApp.Repository
{
    internal class DBcontextClass : DbContext
    {
        public DBcontextClass(DbContextOptions<DBcontextClass> options) :base(options)
        {
            
        }

        DbSet<User> Users { get; set; }
        DbSet<Schedule> Schedules { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().UserSeed();
        }
    }
}
