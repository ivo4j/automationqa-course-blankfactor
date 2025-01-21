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
            var arrLength = arr.Length;
            for (int indexOuter = 0; indexOuter < arrLength - 1; indexOuter++)
                for (int indexInner = 0; indexInner < arrLength - indexOuter - 1; indexInner++)
                    if (arr[indexInner] > arr[indexInner + 1])
                    {
                        var tempVar = arr[indexInner];
                        arr[indexInner] = arr[indexInner + 1];
                        arr[indexInner + 1] = tempVar;
                    }
            return arr;
        }
    }
}


