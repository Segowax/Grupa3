using System;

namespace WebApp.Database.Entietis
{
    public class Item
    {
        private static int _nextId = 1;

        public int Id { get; private set; }
        public Guid Guid { get; private set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Item(string name, int quantity)
        {
            Id = _nextId++;
            Guid = Guid.NewGuid();
            Name = name;
            Quantity = quantity;
        }
    }
}
