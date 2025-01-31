using WebApp.Service.DTO;

namespace WebApp.Service
{
    public interface ILokaleService
    {
        Task AddLokal(LokalDTO lokal);
        Task<LokalDTO> GetLokal(int id);
    }
    
}
