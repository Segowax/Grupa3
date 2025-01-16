namespace WebApp.Domain.Entities
{
    public class Schedule : Base
    {
        
        public string? Description { get; set; }
        public required string Type { get; set; }
    }
}
