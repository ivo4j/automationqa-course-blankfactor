using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsApp5.Methods
{
    internal class FindLargest
    {
        public int FindLargestNumber(int[] numbers)
        {
            if (numbers.Length == 0) return 0;

            var negatives = numbers.All(n => n < 0);
            if (negatives = true) return 0;

            return numbers.Max();
        }
    }
}
