using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Types
{

    /* Task 2: Format a Full Name
Objective: Ask the user to enter their first name and last name, then combine and display them in the format "Last Name, First Name."
Instructions: Use string concatenation or interpolation to format the name. */

    public class FormatFullName
    {

        public void Format()
        {
            // Task 2: Ask the user to enter their first name and last name, then combine and display them in the format "Last Name, First Name."

            Console.WriteLine("Hello, please enter your first name:");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Now please enter your second name:");
            string LastName = Console.ReadLine();


            Console.WriteLine(LastName + ", " + FirstName);
        }
    }
}
