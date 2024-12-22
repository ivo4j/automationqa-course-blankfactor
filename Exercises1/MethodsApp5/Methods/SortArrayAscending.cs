using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsApp5.Methods
{
    internal class SortArrayAscending
    {
        public int[] SortAscending(int[] arr)
        {
            // a bubble sort implementation
            var n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        var tempVar = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tempVar;
                    }
            return arr;
        }
    }
}


