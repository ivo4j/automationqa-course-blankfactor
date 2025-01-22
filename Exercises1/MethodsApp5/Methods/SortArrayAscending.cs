using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsApp5.Methods
{
    internal class SortArrayAscending
    {
        public static int[] EnterAndConvertNumbers()
        {
            Console.WriteLine("Enter a sequence of unordered integer numbers separated by a comma:");
            string unsortedInput = Console.ReadLine();

            try
            {
                // Split the input string by commas
                string[] formattedUnsorted = unsortedInput.Split(',');

                // Convert the array of strings to an array of integers
                int[] intUnordered = Array.ConvertAll(formattedUnsorted, int.Parse);
                //Console.WriteLine("Converted array of integers:");
                //Console.WriteLine(string.Join(", ", intUnordered));
                return intUnordered;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: One or more inputs were not valid integers. Please try again.");
                return EnterAndConvertNumbers();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                return EnterAndConvertNumbers();
            }
        }
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




