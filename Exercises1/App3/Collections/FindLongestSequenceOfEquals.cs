using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3.Collections
{
    internal class FindLongestSequenceOfEquals
    {
        public void FindLongestSequence()
        {
            Console.WriteLine("Please enter a sequence of numbers separated by space: ");
            string numbersInput = Console.ReadLine();

            string[] seqNumbers = numbersInput.Split();

            int[] numbers = Array.ConvertAll(seqNumbers, int.Parse);

            // Variables to track the longest sequence
            int maxLength = 1;
            int maxStartIndex = 0;

            // Variables for the current sequence
            int currentLength = 1;
            int currentStartIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    // Check if the current sequence is the longest
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        maxStartIndex = currentStartIndex;
                    }

                    // Reset for the new sequence
                    currentLength = 1;
                    currentStartIndex = i;
                }
            }

            // Final check for the last sequence
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                maxStartIndex = currentStartIndex;
            }

            // Output the longest sequence
            Console.WriteLine("Longest sequence:");
            for (int i = 0; i < maxLength; i++)
            {
                Console.Write(numbers[maxStartIndex + i] + " ");
            }


        }
    }
}
