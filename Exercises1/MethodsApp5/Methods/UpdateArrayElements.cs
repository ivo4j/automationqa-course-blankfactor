using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsApp5.Methods
{
    internal class UpdateArrayElements
    {
        public void UpdateArray(ref int[] arr, int factor) 
        {
            for (int index = 0; index < arr.Length; index++)
            {
                arr[index] *= factor;
            }
        }

        public void PrintArray(int[] array)
        {
            foreach (var num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
