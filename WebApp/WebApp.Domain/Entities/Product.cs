using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain.Entities
{
    public class Product : Base
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required double? Price { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public required int CategoryId { get; set; }
        public required int Stock {  get; set; }

        public required string ImageUrl { get; set; }
        

    }
}
