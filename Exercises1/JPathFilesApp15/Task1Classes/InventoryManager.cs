using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

namespace JPathFilesApp15.Task1Classes
{
    internal class InventoryManager
    {

        private const string FilePath = "inventory.json";

        public List<Product> LoadInventory()
        {
            if (!File.Exists(FilePath))
            {
                File.WriteAllText(FilePath, "[]"); // Create an empty JSON file if it doesn't exist
            }

            string json = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<List<Product>>(json) ?? new List<Product>();
        }

        public void SaveInventory(List<Product> products)
        {
            string json = JsonConvert.SerializeObject(products, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        public void AddProduct(Product newProduct)
        {
            var products = LoadInventory();

            if (products.Any(p => p.ProductId == newProduct.ProductId))
            {
                Console.WriteLine($"Error: Product with ID {newProduct.ProductId} already exists.");
                return;
            }

            products.Add(newProduct);
            SaveInventory(products);
            Console.WriteLine($"Product '{newProduct.ProductName}' added successfully.");
        }

        public void CalculateTotalStockValue()
        {
            var products = LoadInventory();
            var categoryValues = products.GroupBy(p => p.Category)
                                         .Select(g => new
                                         {
                                             Category = g.Key,
                                             TotalValue = g.Sum(p => p.Price * p.Stock)
                                         });

            Console.WriteLine("\nTotal Stock Value by Category:");
            foreach (var category in categoryValues)
            {
                Console.WriteLine($"{category.Category}: ${category.TotalValue:F2}");
            }
        }

        public void FindBestSellingProduct()
        {
            var products = LoadInventory();
            var bestSellingProduct = products.OrderByDescending(p => p.Sales.Sum()).FirstOrDefault();

            if (bestSellingProduct != null)
            {
                Console.WriteLine($"\nBest-Selling Product: {bestSellingProduct.ProductName} (Total Sales: {bestSellingProduct.Sales.Sum()})");
            }
        }

        public void UpdateStock(int productId, int newStock)
        {
            var products = LoadInventory();
            var product = products.FirstOrDefault(p => p.ProductId == productId);

            if (product == null)
            {
                Console.WriteLine($"Error: No product found with ID {productId}.");
                return;
            }

            product.Stock = newStock;
            SaveInventory(products);
            Console.WriteLine($"Stock updated successfully for '{product.ProductName}'. New Stock: {newStock}");
        }
    }
}
