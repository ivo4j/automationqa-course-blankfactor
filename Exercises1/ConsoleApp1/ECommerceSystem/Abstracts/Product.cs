using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAbstractionApp9.ECommerceSystem.Abstracts
{
    public abstract class Product
    {
        // Fields
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Constructor
        protected Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        // Concrete method to display product details
        public void DisplayInfo()
        {
            Console.WriteLine($"Product: {Name}, Original Price: {Price:C}");
        }

        // Abstract method to calculate the discounted price
        public abstract decimal GetDiscountedPrice();
    }
}
