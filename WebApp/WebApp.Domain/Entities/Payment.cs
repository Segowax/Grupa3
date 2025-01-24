using System.ComponentModel.DataAnnotations.Schema;
using WebApp.Domain.Enum;

namespace WebApp.Domain.Entities
{
    public class Payment : Base
    {
        [ForeignKey(nameof(Order.Id))]
        public required int OrderId { get; set; }

        public required DateTime PaymentDate { get; set; }

        public required double Amount { get; set; }

        public required string PaymentMethod { get; set; }

        public string PaymentStatus { get; set; } = PaymentStatusEnum.Pending.ToString();

    }
}
