using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3.Collections
{
    public class BasicQuequeOperations
    {
        public void QuequeOperations()
        {
            Console.WriteLine("Please enter N, S and X, separated by a single space:");
            // Read input parameters: N, S, X
            int[] inputParams = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int N = inputParams[0]; // Number of elements to enqueue
            int S = inputParams[1]; // Number of elements to dequeue
            int X = inputParams[2]; // Element to look for

            Console.WriteLine("Please enter the N number of integers, separated by a single space:");
            // Read the elements to enqueue
            int[] elements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>();

            // Enqueue the first N elements
            for (int i = 0; i < N; i++)
            {
                queue.Enqueue(elements[i]);
            }

            // Dequeue the top S elements
            for (int i = 0; i < S && queue.Count > 0; i++)
            {
                queue.Dequeue();
            }

            // Check if X is present in the queue
            if (queue.Contains(X))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count > 0)
            {
                // Print the smallest element in the queue
                Console.WriteLine(queue.Min());
            }
            else
            {
                // Queue is empty
                Console.WriteLine(0);
            }

        }
    }
}
