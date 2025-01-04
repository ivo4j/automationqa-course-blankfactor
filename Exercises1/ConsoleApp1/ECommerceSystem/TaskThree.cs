using EncapsulationAbstractionApp9.ECommerceSystem.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAbstractionApp9.ECommerceSystem
{
    internal class TaskThree
    {
        public void TaskThreeStart()
        {
            // Create a list of products
            List<Product> products = new List<Product>
            {
                new Electronics("Smartphone", 699.99m),
                new Electronics("Laptop", 999.99m),
                new Clothing("T-Shirt", 19.99m),
                new Clothing("Jeans", 49.99m)
            };

            // Display product details and discounted prices
            foreach (var product in products)
            {
                product.DisplayInfo();
                Console.WriteLine($"Discounted Price: {product.GetDiscountedPrice():C}\n");
            }
        }
    }
}
