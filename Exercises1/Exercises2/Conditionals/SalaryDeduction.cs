using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.Conditionals
{
    internal class SalaryDeduction
    {

        public void SalaryDeduct()
        {
            int openedTabs = 0, salary = 0, n = 0, fine = 0;
            string website = string.Empty, currentWebsite = string.Empty;
            bool socialMedia = false;

            // input
            do
            {
                Console.WriteLine("Please enter the number of opened tabs - between 1 and 10:");
                bool res1 = int.TryParse(Console.ReadLine(), out openedTabs);
            }
            while (openedTabs < 1 || openedTabs > 10);

            do
            {
                Console.WriteLine("Please enter the salary amount - between 700 and 1500:");
                bool res2 = int.TryParse(Console.ReadLine(), out salary);
            }
            while (salary < 1 || salary > 8000);


            //
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine($"Tab number {i}: please enter the website:");
                website = Console.ReadLine();

                switch (website)
                {
                    case "Facebook": fine = 150; socialMedia = true; break;
                    case "Instagram": fine = 100; socialMedia = true; break;
                    case "Reddit": fine = 50; socialMedia = true; break;
                }

                if (socialMedia)
                {
                    salary -= fine;

                }

            }

            if (salary <= 0) Console.WriteLine("You have lost your salary");
            else Console.WriteLine($"The remaining salary is {salary}");
        }
    }
}
