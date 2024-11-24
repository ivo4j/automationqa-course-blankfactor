using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Types
{
    internal class ValidateAge
    {

        /* Task 5: Validate Age Input
Objective: Ask the user to enter their age. Use TryParse() to check if the input is a valid integer, and display a message based on whether the age is valid or not.
Instructions: If TryParse returns false, display "Invalid age entered."  */
        internal void Validate()
        {
            int age;
            Console.WriteLine("Please enter your age:");
            bool res = int.TryParse(Console.ReadLine(), out age);

            if (res == false) { Console.WriteLine("Invalid age entered."); }

        }

    }
}
