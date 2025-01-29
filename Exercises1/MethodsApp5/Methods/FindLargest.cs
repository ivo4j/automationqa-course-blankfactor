using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsApp5.Methods
{
    internal class FindLargest
    {
       /* public int FindLargestNumber(int[] numbers)
        {
            if (numbers.Length == 0) return 0;

            var negatives = numbers.All(n => n < 0);
            if (negatives = true) return 0;

            return numbers.Max();
        }  */

        public int? FindLargestNumber(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return null; // Return null for empty arrays
            }
            //return numbers.Max(); // Find and return the largest number

            int largest = numbers[0]; // Assume the first number is the largest

            foreach (int num in numbers)
            {
                if (num > largest)
                {
                    largest = num; // Update largest if a bigger number is found
                }
            }

            return largest;
        }

        public int[] ParseInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return new int[0]; // Return an empty array for invalid input
            }

            return input.Split(' ')
                        .Where(s => int.TryParse(s, out _)) // Filter out invalid entries
                        .Select(int.Parse)
                        .ToArray();
        }
    }
}
