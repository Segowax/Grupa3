using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Domain.Entities
{
    public class Discount : Base
    {
        [ForeignKey(nameof(Product.Id))]
        public required int ProductId { get; set; }

        public required int DiscountPercentage { get; set; }

        public required DateTime ValidFrom { get; set; }
        public required DateTime ValidUntil { get; set; }
    }
}
