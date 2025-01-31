namespace WebApp.Domain.Entities
{
    public class Lokale : Base
    {
        public required string Nazwa { get; set; }
        public required string Miasto { get; set; }
        public required string Ulica { get; set; }
        public required int Numer { get; set; }
    }
}
