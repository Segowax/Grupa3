namespace WebApp.Domain.Entities
{
    public class Pracownicy : Base
    {
        public required string Imie { get; set; }
        public required string Nazwisko { get; set; }
        public required int Stanowisko { get; set; }
    }
}
