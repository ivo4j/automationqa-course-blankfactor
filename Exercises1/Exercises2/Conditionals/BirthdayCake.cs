using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace App2.Conditionals
{
    internal class BirthdayCake
    {
        public void CalculatePieces()
        {
            int width = 0, height = 0, pieces = 0, eatenPieces = 0;
            string input = null;
            bool res1 = true, res2 = true;

            // input
            do
            {
                Console.WriteLine("Please enter the cake's width and height: an integer between 1 and 1000:");
                res1 = int.TryParse(Console.ReadLine(), out width);
            }
            while (width < 1 || width > 1000);

            // calculate the pieces
            do
            {
                Console.WriteLine("Please enter how many pieces the guests took or type 'STOP': ");
                input = Console.ReadLine();

                if (input != "STOP")
                {
                    res2 = int.TryParse(input, out pieces);
                    eatenPieces += pieces;

                }
                else
                {
                    switch (eatenPieces)
                    {
                        case int i when (i < width):
                            Console.WriteLine($"{width - eatenPieces} pieces are left");
                            break;
                        case int i when (i == width):
                            Console.WriteLine("The pieces of cake are just the right number.");
                            break;
                        case int i when (i > width):
                            Console.WriteLine($"No more cake left! You need {eatenPieces - width} pieces more");
                            break;
                    }

                }
            } while (input != "STOP");


        }
    }
}



