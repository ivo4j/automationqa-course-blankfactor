using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Types
{
    internal class ConvertAndAdd
    {

        /* Task 1: Convert and Add Two Numbers
Objective: Prompt the user to input two numbers as strings, convert them to integers, and display their sum.
Instructions: Use int.Parse() or TryParse() to convert the inputs to integers.*/
        public void Convert()
        {


            int number1 = 0, number2 = 0, sum = 0;
            Console.WriteLine("Please enter the first number:");
            bool res1 = int.TryParse(Console.ReadLine(), out number1);

            Console.WriteLine("Please enter the second number:");
            bool res2 = int.TryParse(Console.ReadLine(), out number2);

            sum = number1 + number2;
            Console.WriteLine($"The sum of {number1} and {number2} is {sum}.");


            /* Console.Write("Enter steps or go home: ");
             string input = Console.ReadLine();
             TakingSteps(input);

             static void TakingSteps(string input)
             {
                 if (input == "Going home")
                 {
                     Console.Write("Enter the steps before you going home: ");
                     int finalSteps = int.Parse(Console.ReadLine());

                     Console.WriteLine("Difference: " + (10000 - finalSteps));
                 }
             } */
        }
    }
}
