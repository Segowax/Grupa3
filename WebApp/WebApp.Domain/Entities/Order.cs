using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain.Enum;

namespace WebApp.Domain.Entities
{
    public class Order : Base
    {

        [ForeignKey(nameof(User.Id))]
        public required int UserId {  get; set; }
        public string Status { get; set; } = OrderStatus.Prepaired.ToString();
        public required double TotalPrice { get; set; }

    }
}
