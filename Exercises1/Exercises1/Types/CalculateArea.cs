using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Types
{
    /* Task 4: Calculate the Area of a Circle
Objective: Prompt the user to input the radius as a string, convert it to a double, and calculate the area using the formula π * radius * radius.
Instructions: Use double.Parse() and math operations. Display the result as a formatted string with two decimal places  */
    public class CalculateArea
    {
        public void Calculate()
        {
            Console.WriteLine("Hello, please enter the radius of the circle:");
            string string1 = Console.ReadLine();
            double radius = double.Parse(string1);

            double area = Math.PI * radius * radius;
            double result = Math.Round(area, 2);

            Console.WriteLine($"The area is: {area}");
        }
    }
}
