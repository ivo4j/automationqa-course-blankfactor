using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.Conditionals
{
    internal class Steps
    {
        public void StepsToCount() 
        {
            string input = string.Empty;
            int currentSteps = 0, steps = 0, goalSteps = 10_000;
            bool goingHome = false;

            do
            {
                Console.WriteLine("Please enter a number of steps or 'Going home':");
                input = Console.ReadLine();

                if (input != "Going home")
                {
                    bool res1 = int.TryParse(Console.ReadLine(), out steps);
                    currentSteps = goalSteps - steps;
                    if (currentSteps <= goalSteps) Console.WriteLine("Goal reached! Good job!"); 
                } else
                {

                }
            }
            while (true); 
            
    
        
        }
    }
}
