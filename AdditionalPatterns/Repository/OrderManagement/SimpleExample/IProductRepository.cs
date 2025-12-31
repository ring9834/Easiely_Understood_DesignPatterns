using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.SimpleExample
{
    // 2. REPOSITORY INTERFACE (The contract)
    // This interface defines the contract for data operations, decoupling the application logic from the persistence mechanism.
    public interface IProductRepository
    {
        // CRUD Operations
        Product GetById(int id);
        IEnumerable<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);

        // Custom query methods can also be defined here:
        // IEnumerable<Product> GetByPriceRange(decimal min, decimal max);
    }
}
