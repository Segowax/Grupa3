namespace WebApp.Domain.Entities
{
    public class Rezerwacje : Base
    {
        public required int NrStolika { get; set; }
        public required DateTime DataRez { get; set; }
        public required int LiczbaOsob { get; set; }
        public required string Telefon { get; set; }
    }
}
