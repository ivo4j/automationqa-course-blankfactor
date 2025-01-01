using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsApp4.Collections
{
    public class CountCharsInString
    {

        public void CountChars()
        {
            // Input: Get the string
            Console.WriteLine("Enter the string:");
            string input = Console.ReadLine();

            // Dictionary to store character counts
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            // Process each character in the string
            foreach (char c in input)
            {
                if (c != ' ') // Ignore spaces
                {
                    if (charCounts.ContainsKey(c))
                    {
                        charCounts[c]++;
                    }
                    else
                    {
                        charCounts[c] = 1;
                    }
                }
            }

            // Output the results
            foreach (var pair in charCounts)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }


    }
}
