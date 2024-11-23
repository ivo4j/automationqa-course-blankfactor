using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises1
{
    internal class ValidateAge
    {
        static void Main()
        {
            int age;
            Console.WriteLine("Please enter your age:");
            bool res = int.TryParse(Console.ReadLine(), out age);

            if (res == false) { Console.WriteLine("Invalid age entered."); }

        }

    }
}
