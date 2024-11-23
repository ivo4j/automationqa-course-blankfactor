using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type
{
    internal class ConvertAndAdd
{
    public void Convert()
    {

        Console.Write("Enter steps or go home: ");
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
        }
    }
}
}
