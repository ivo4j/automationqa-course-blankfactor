using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3.Collections
{
    internal class BasicStackOperations
    {
        public void StackOperations()
        {
            Console.WriteLine("Please enter N, S and X, separated by a single space:");
            // Read input parameters: N, S, X
            int[] inputParams = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int N = inputParams[0]; // Number of elements to push
            int S = inputParams[1]; // Number of elements to pop
            int X = inputParams[2]; // Element to look for

            Console.WriteLine("Please enter the N number of integers, separated by a single space:");
            // Read the elements to push onto the stack
            int[] elements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();

            // Push the first N elements into the stack
            for (int i = 0; i < N; i++)
            {
                stack.Push(elements[i]);
            }

            // Pop the top S elements from the stack
            for (int i = 0; i < S && stack.Count > 0; i++)
            {
                stack.Pop();
            }

            // Check if X is present in the stack
            if (stack.Contains(X))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count > 0)
            {
                // Print the smallest element in the stack
                Console.WriteLine(stack.Min());
            }
            else
            {
                // Stack is empty
                Console.WriteLine(0);
            }
        }
    }
}
