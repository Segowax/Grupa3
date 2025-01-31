using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain.Entities
{
    public class Review : Base
    {
        [ForeignKey(nameof(Product.Id))]
        public required int ProductId { get; set; }

        [ForeignKey(nameof(User.Id))]
        public required int UserId { get; set; }
        public double? Rating { get; set; }
        public string? Comment { get; set; }

    }
}
