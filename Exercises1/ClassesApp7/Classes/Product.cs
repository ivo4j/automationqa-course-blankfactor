using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp7.Classes
{
    internal class Product
    {
        // Fields
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        // Default Constructor
        public Product()
        {
            Name = null;
            Price = 0.0m;
            Quantity = 0;
        }

        // Parameterized Constructor
        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        // Method to calculate total cost
        public decimal CalculateTotalCost()
        {
            return Price * Quantity;
        }
    }
}
