using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.SimpleExample
{
    // The client code only references the IProductRepository interface, completely unaware that the data is stored in a simple list.
    // The most important aspect of the Repository Pattern shown here is that the Program class (the business logic) only interacts
    // with the IProductRepository interface. It doesn't know (or care) about the List<Product> used inside InMemoryProductRepository.
    // This separation allows developers to later replace InMemoryProductRepository with a SqlProductRepository or CosmosDbProductRepository
    // without modifying the business logic code.
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Repository Pattern Demo ---\n");

            // The application depends on the INTERFACE, not the concrete implementation.
            // This makes it easy to swap InMemoryProductRepository for SqlProductRepository later.
            IProductRepository repository = new InMemoryProductRepository();

            // 1. READ ALL
            Console.WriteLine("--- Initial Products ---");
            PrintProducts(repository);

            // 2. CREATE
            var newProduct = new Product { Name = "Mouse", Price = 25.99m };
            repository.Add(newProduct);

            // 3. UPDATE
            var laptop = repository.GetById(1);
            if (laptop != null)
            {
                laptop.Price = 1150.00m; // Changed the price
                repository.Update(laptop);
            }

            // 4. READ ALL (after CUD operations)
            Console.WriteLine("\n--- Products After CUD Operations ---");
            PrintProducts(repository);

            // 5. DELETE
            repository.Delete(2); // Delete Keyboard

            // 6. FINAL CHECK
            Console.WriteLine("\n--- Final Product List ---");
            PrintProducts(repository);
        }

        private static void PrintProducts(IProductRepository repo)
        {
            foreach (var p in repo.GetAll())
            {
                Console.WriteLine($"  -> {p}");
            }
        }
    }
}
