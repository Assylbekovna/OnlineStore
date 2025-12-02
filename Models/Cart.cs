using System.Collections.Generic;
using System.Linq;

namespace OnlineOrderSystem.Models
{
    public class Cart
    {
        private readonly List<Product> _items = new();

        public void Add(Product product) => _items.Add(product);

        public decimal Total => _items.Sum(p => p.Price);

        public bool IsEmpty => !_items.Any();

        public List<Product> Items => _items;
    }
}
