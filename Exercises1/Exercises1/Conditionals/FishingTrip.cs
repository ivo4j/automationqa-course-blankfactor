using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises1.Conditionals
{
    internal class FishingTrip
    {
          static void Main()   {
            int budget = 0;
            string season = "";

            while (budget < 1 || budget > 8000) { 
            Console.WriteLine("Please enter the group budget - between 1 and 8000:");
            budget = Console.ReadLine();

            while (season != "Spring" || season != "Summer" || season != "Autumn" || season != "Winter") { 
            Console.WriteLine("Please enter a season - Spring, Summer, Autumn or Winter:");
            season = Console.ReadLine();

            }
            
        
          }
    }
}
