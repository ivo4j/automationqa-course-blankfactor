using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismApp8.TaskFour
{
    internal class MathOperations
    {

        // Method to add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method to add three doubles
        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }

        // Method to add three decimals
        public decimal Add(decimal a, decimal b, decimal c)
        {
            return a + b + c;
        }
    }
}
