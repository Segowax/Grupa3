
using WebApp.Repository.Repositories.Interfaces;
using WebApp.Service.DTO;
using WebApp.Service.Mapper;

namespace WebApp.Service
{
    internal class LokaleService : ILokaleService
    {
        private readonly ILokaleRepository _LokaleRepository;

        public LokaleService(ILokaleRepository LokaleRepository)
        {
            _LokaleRepository = LokaleRepository;
        }

        public Task AddLokal(LokalDTO lokal)
        {
            throw new NotImplementedException();
        }

        public async Task AddLokale(LokalDTO LokaleDto)
        {
            var Lokale = LokaleDto.MapToLokal();
            await _LokaleRepository.Add(Lokale);
        }

        public Task<LokalDTO> GetLokal(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<LokalDTO> GetLokale(int id)
        {
           var Lokale =  await _LokaleRepository.Get(id);     
           return Lokale?.MapToEntity() ?? throw new Exception("");
        }
    }
}
