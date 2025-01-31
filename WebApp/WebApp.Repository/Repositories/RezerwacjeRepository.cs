using WebApp.Domain.Entities;
using WebApp.Repository.Repositories.Interfaces;

namespace WebApp.Repository.Repositories
{
    public class RezerwacjeRepository : BaseRepository<Rezerwacje>, IRezerwacjeRepository
    {
        public RezerwacjeRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext) { }
    }
}
