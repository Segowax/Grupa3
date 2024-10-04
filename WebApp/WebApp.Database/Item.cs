using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Database
{
    internal class Item
    {
        public int Id { get; set; }
        public Guid Guid{  get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
