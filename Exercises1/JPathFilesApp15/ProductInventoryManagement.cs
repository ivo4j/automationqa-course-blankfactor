using JPathFilesApp15.Task1Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPathFilesApp15
{
    internal class ProductInventoryManagement
    {
        public void ProductInventoryMnmnt()
        {
            InventoryManager manager = new InventoryManager();

            // Add a new product (ensuring no duplicate productId)
            manager.AddProduct(new Product
            {
                ProductId = 103,
                ProductName = "Smartphone",
                Category = "Electronics",
                Price = 899.99M,
                Stock = 20,
                Sales = new List<int> { 7, 10, 9 }
            });

            // Calculate total stock value for each category
            manager.CalculateTotalStockValue();

            // Find the best-selling product
            manager.FindBestSellingProduct();

            // Update stock quantity for a product by ProductId
            manager.UpdateStock(101, 25);

        }
    }
}
