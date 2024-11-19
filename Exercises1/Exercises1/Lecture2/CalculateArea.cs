using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises1.Lecture2
{
    internal class CalculateArea
    {
        static void Main()
        {
            Console.WriteLine("Hello, please enter the radius of the circle:");
            string string1 = Console.ReadLine();
            double radius = double.Parse(string1);

            double area = Math.PI * radius * radius;
            double result = Math.Round(area, 2);

            Console.WriteLine($"The area is: {area}");
        }
    }
