using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsApp5.Methods
{
    internal class SwapTwoNumbers
    {
        public void SwapTheNumbers(ref int first, ref int second) 
        {
            int temp = first;
            first = second;
            second = temp;
        }
    }
}
