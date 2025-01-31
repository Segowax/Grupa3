using WebApp.Domain.Entities;
using WebApp.Repository.Repositories.Interfaces;

namespace WebApp.Repository.Repositories
{
    public class DaniaRepository : BaseRepository<Dania>, IDaniaRepository
    {
        public DaniaRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext) { }
    }
}
