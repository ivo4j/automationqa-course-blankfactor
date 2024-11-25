using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.Conditionals;

internal class CinemaHall
{

    public void Calculation()
    {
        string screeningChoice = "";
        int rows = 0;
        int columns = 0;
        double premiereProfit = 0;
        double normalProfit = 0;
        double discountProfit = 0;
        bool premierSelected = false, normalSelected = false, discountSelected = false;
        do
        {
            do
            {
                Console.WriteLine("Please enter the type of screening - Premiere, Normal or Discount:");
                screeningChoice = Console.ReadLine();
            }
            while (screeningChoice != "Premiere" || screeningChoice != "Normal" || screeningChoice != "Discount");

            Console.WriteLine("Please enter a number of rows for the screening:");
            rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a number of columns for the screening:");
            columns = int.Parse(Console.ReadLine());

            switch (screeningChoice)
            {
                case "Premiere": premiereProfit = 12.00 * rows * columns; break;
                case "Normal": normalProfit = 7.50 * rows * columns; break;
                case "Discount": discountProfit = 5.00 * rows * columns; break;
            }
        }
        while (premierSelected || normalSelected || discountSelected);

        double totalSum = premiereProfit + normalProfit + discountProfit;
        Console.WriteLine($"The totalsum is {totalSum}");

    }
}
