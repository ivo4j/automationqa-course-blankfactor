using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAbstractionApp9.ECommerceSystem
{
    internal class Clothing: Abstracts.Product
    {
        // Constructor
        public Clothing(string name, decimal price) : base(name, price) { }

        // Implementation of GetDiscountedPrice
        public override decimal GetDiscountedPrice()
        {
            return Price * 0.80m; // 20% discount
        }
        
    }
}
