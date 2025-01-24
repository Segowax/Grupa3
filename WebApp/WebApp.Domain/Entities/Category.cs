using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain.Entities
{
    public class Category : Base
    {
        public required string Name { get; set; }
        public string? Description { get; set; }

        [ForeignKey(nameof(Category.Id))]
        public required int ParentCategoryId { get; set; }


    }
}
