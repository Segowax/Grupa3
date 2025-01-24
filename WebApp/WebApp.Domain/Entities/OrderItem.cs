using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain.Entities
{
    public class OrderItem : Base
    {
        [ForeignKey(nameof(Order.Id))]
        public required int OrderId { get; set; }

        [ForeignKey(nameof(Product.Id))]
        public required int ProductId { get; set; }

        public required int Quantity { get; set; }

        // Cena towaru na moment pokupki
        public required double Price { get; set; }


    }
}
