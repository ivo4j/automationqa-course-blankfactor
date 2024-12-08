using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3.Collections
{
    internal class PrintCommonElements
    {
        public void PrintElements() 
        {
            Console.WriteLine("Enter the string 1: ");
            string string1 = Console.ReadLine();

            Console.WriteLine("Enter the string 2: ");
            string string2 = Console.ReadLine();

            string[] items1 = string1.Split("");
            string[] items2 = string2.Split("");

            //foreach (string item in items1) Console.WriteLine(item);
            //foreach (string item in items2) Console.WriteLine(item);

            for (int i = 0; i < items2.Length; i++)
            {
                for (int j = 0; j < items1.Length; j++)
                {
                    if (items2[i] == items1[j]) Console.Write(items2[i] + " ");
                }
            }
        }
    }
}
