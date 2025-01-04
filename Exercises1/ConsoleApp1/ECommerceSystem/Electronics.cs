using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAbstractionApp9.ECommerceSystem
{
    internal class Electronics : Abstracts.Product
    {
        // Constructor
        public Electronics(string name, decimal price) : base(name, price) { }

        // Implementation of GetDiscountedPrice
        public override decimal GetDiscountedPrice()
        {
            return Price * 0.90m; // 10% discount
        }
    }
}
