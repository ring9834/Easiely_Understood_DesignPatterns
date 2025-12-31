using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.SimpleExample
{
    // 3. CONCRETE REPOSITORY (The data access implementation)
    // This class implements the interface, using an in-memory List<T> to simulate a database. In a real-world application,
    // this is where you would use Entity Framework Core, Dapper, or raw ADO.NET.
    public class InMemoryProductRepository : IProductRepository
    {
        // Simulate a data store (e.g., a database table)
        private readonly List<Product> _products = new List<Product>
    {
        new Product { Id = 1, Name = "Laptop", Price = 1200.00m },
        new Product { Id = 2, Name = "Keyboard", Price = 75.50m }
    };

        // Helper to generate unique IDs
        private int _nextId = 3;

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public void Add(Product product)
        {
            product.Id = _nextId++;
            _products.Add(product);
            Console.WriteLine($"\n[Repository]: Added new product: {product.Name}");
        }

        public void Update(Product product)
        {
            Product existing = GetById(product.Id);
            if (existing != null)
            {
                existing.Name = product.Name;
                existing.Price = product.Price;
                Console.WriteLine($"\n[Repository]: Updated product ID {product.Id} to Price: {product.Price:C}");
            }
        }

        public void Delete(int id)
        {
            Product productToRemove = GetById(id);
            if (productToRemove != null)
            {
                _products.Remove(productToRemove);
                Console.WriteLine($"\n[Repository]: Deleted product ID {id} ({productToRemove.Name}).");
            }
        }
    }
}
