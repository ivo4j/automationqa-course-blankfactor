using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsApp5.Methods
{
    internal class DivideTwoNumbers
    {
        public void DivideTheNumbers(int dividend, int divisor, out int quotient, out int remainder) 
        {
            // Calculate quotient and remainder
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }
    }
}
