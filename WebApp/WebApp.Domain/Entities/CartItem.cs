using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Domain.Entities
{
    public class CartItem : Base
    {
        [ForeignKey(nameof(Cart.Id))]
        public required int CartId { get; set; }

        [ForeignKey(nameof(Product.Id))]
        public required int ProductId { get; set; }

        public required int Quantity { get; set; }

    }
}
