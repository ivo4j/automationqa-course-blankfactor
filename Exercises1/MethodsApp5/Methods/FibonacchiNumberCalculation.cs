using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsApp5.Methods
{
    internal class FibonacchiNumberCalculation
    {
        public int CalculateFibNumber(int number)
        {
            if (number < 2)
                return number;
            else
                return CalculateFibNumber(number - 1) + CalculateFibNumber(number - 2);
        
        }
    }
}
