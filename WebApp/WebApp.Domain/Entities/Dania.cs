namespace WebApp.Domain.Entities
{
    public class Dania : Base
    {
        public required int Typ { get; set; }
        public required string Nazwa { get; set; }
        public required int Cena { get; set; }
    }
}
