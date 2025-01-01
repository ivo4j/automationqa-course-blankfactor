using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace App3.Collections
{
    internal class PrintCommonElements
    {
        public void PrintElements() 
        {
            Console.WriteLine("Enter the string 1 - elements to be separated by space: ");
            string[] array1 = Console.ReadLine().Split(' ');

            Console.WriteLine("Enter the string 2 - elements to be separated by space: ");
            string[] array2 = Console.ReadLine().Split(' ');

            Console.WriteLine("Common elements:");
            foreach (var element in array2)
            {
                if (Array.Exists(array1, e => e == element))
                {
                    Console.Write(element + " ");
                }
            }
        }
    }
}
