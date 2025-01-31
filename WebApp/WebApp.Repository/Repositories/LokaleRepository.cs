using WebApp.Domain.Entities;
using WebApp.Repository.Repositories.Interfaces;

namespace WebApp.Repository.Repositories
{
    public class LokaleRepository : BaseRepository<Lokale>, ILokaleRepository
    {
        public LokaleRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext) { }
    }
}
