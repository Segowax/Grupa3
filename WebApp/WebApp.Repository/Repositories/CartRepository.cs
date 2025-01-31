using WebApp.Domain.Entities;
using WebApp.Repository.Repositories.Interfaces;

namespace WebApp.Repository.Repositories
{
    public class CartRepository : BaseRepository<Cart>, ICartRepository
    {
        public CartRepository(ApplicationDbContext context) 
            : base(context) { }
    }
}