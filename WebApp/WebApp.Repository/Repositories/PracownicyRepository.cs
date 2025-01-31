using WebApp.Domain.Entities;
using WebApp.Repository.Repositories.Interfaces;

namespace WebApp.Repository.Repositories
{
    public class PracownicyRepository : BaseRepository<Pracownicy>, IPracownicyRepository
    {
        public PracownicyRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext) { }
    }
}
