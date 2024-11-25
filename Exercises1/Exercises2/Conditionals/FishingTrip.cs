using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.Conditionals
{
    internal class FishingTrip
    {
        public void TripCalculation()
        {
            int budget = 0;
            string season = "";
            int numberOfFishermen = 0;
            int rentalCoast = 0;
            int discount = 0;
            int additionalDiscount = 5;
            int totalSum = 0;

            // input of 3 types of data
            do
            {
                Console.WriteLine("Please enter the group budget - between 1 and 8000:");
                bool res1 = int.TryParse(Console.ReadLine(), out budget);
            }
            while (budget < 1 || budget > 8000);

            do
            {
                Console.WriteLine("Please enter a season - Spring, Summer, Autumn or Winter:");
                season = Console.ReadLine();

            }
            while (season != "Spring" || season != "Summer" || season != "Autumn" || season != "Winter");

            do
            {

                Console.WriteLine("Please enter the number of fishermen - between 4 and 18:");
                bool res2 = int.TryParse(Console.ReadLine(), out numberOfFishermen);

            }
            while (numberOfFishermen < 4 || numberOfFishermen > 18);


            // calculate the 
            switch (season)
            {
                case "Spring": rentalCoast = 3000;
                    break;
                case "Summer":
                case "Autumn": rentalCoast = 4200;
                    break;
                case "Winter": rentalCoast = 2600;
                    break;
                default:
                    break;

            }

            switch (numberOfFishermen)
            {
                case int i when (i <= 6): discount = 10;
                    break;
                case int i when (i >= 7 && i <= 11): discount = 15;
                    break;
                case int i when (i >= 12): discount = 25;
                    break;
                default:
                    break;
            }

            discount = (numberOfFishermen % 2 == 0) ? discount + additionalDiscount : discount;


            totalSum = rentalCoast * (100 - discount);

            if (totalSum <= budget) Console.WriteLine("You have gathered enough money!");
            else Console.WriteLine("The gathered money is not sufficient to hire a boat!");
        }
    }
}
