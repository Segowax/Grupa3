using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Domain.Entities
{
    public class Cart : Base
    {
        [ForeignKey(nameof(User.Id))]
        public required int UserId { get; set; }

    }
}
