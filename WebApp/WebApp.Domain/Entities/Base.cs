namespace WebApp.Domain.Entities
{
    public abstract class Base
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public required string Name { get; set; }
    }
}
