using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsApp5.Methods
{
    internal class FibonacchiNumberCalculation
    {
        public int CalculateFibNumber(int number)
        {
              if (number < 2)
                  return number;
              else
                  return CalculateFibNumber(number - 1) + CalculateFibNumber(number - 2); 

          /*  long firstFib = 0, secondFib = 1, next = 0; // First two Fibonacci numbers

            for (int index = 0; index < number; index++)
            {
                //Console.Write(firstFib + " ");  // Print the current Fibonacci number
                next = firstFib + secondFib; // Compute the next Fibonacci number
                firstFib = secondFib;  // Shift left
                secondFib = next;
            }
            Console.WriteLine($"It's {next}"); */
            
        }
    }
}
