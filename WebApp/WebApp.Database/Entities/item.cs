using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Database.Entities
{
    internal class item
    {
        public int Id { get; set; }
        private Guid Guid { get; set; }
        private string Name { get; set; }
        private int Quantity { get; set; }

    }
}
