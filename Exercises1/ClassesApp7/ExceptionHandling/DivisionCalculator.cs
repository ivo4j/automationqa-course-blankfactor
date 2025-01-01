using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp7.ExceptionHandling
{
    internal class DivisionCalculator
    {
        public void Divide()
        {
            try
            {
                Console.Write("Enter the dividend (integer): ");
                int dividend = int.Parse(Console.ReadLine());

                Console.Write("Enter the divisor (integer): ");
                int divisor = int.Parse(Console.ReadLine());

                // Call the DivideNumbers method and display the result
                string result = DivideNumbers(dividend, divisor);
                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid integers.");
            }
        }

        /// <summary>
        /// Divides two numbers and handles divide by zero exceptions.
        /// </summary>
        /// <param name="dividend">The number to be divided.</param>
        /// <param name="divisor">The number to divide by.</param>
        /// <returns>A string with the result or an error message.</returns>
        static string DivideNumbers(int dividend, int divisor)
        {
            try
            {
                int result = dividend / divisor;
                return result.ToString();
            }
            catch (DivideByZeroException)
            {
                return "Error: Division by zero is not allowed.";
            }

        }
    }
}
