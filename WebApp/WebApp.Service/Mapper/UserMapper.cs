using WebApp.Domain.Entities;
using WebApp.Service.DTO;

namespace WebApp.Service.Mapper
{
    internal static class UserMapper
    {
        internal static Lokale MapToLokal(this LokalDTO lokalDTO) =>
            new()
            {
                Nazwa = lokalDTO.Nazwa,
                Miasto = lokalDTO.Miasto,
                Ulica = lokalDTO.Ulica,
                Numer = lokalDTO.Numer
            };

        internal static LokalDTO MapToEntity(this Lokale lokal) =>
            new()
            {
                Nazwa = lokal.Nazwa,
                Miasto = lokal.Miasto,
                Ulica = lokal.Ulica,
                Numer = lokal.Numer
            };
    }
}
