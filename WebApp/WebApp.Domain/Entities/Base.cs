using System.ComponentModel.DataAnnotations;

namespace WebApp.Domain.Entities
{
    public abstract class Base
    {
        [Key]
        public int Id { get; set; }
        public Guid Guid { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime LastModifiedDate { get; set; } = DateTime.Now;
    }
}
