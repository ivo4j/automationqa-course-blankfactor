

namespace App2.Conditionals
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class PasswordGenerator
    {
        public void Generate() 
        {
            int n = 0, l = 0, tempNumber = 0;
            // input
            do
            {
                Console.WriteLine("Please enter the first integer n - between 1 and 9:");
                bool res2 = int.TryParse(Console.ReadLine(), out n);
            }
            while (n < 1 || n > 9);

            do
            {
                Console.WriteLine("Please enter the 2nd integer l - between 1 and 9:");
                bool res2 = int.TryParse(Console.ReadLine(), out l);
            }
            while (l < 1 || l > 9);


            // generate the symbols
            Random rnd = new Random();
            // 1st and 2nd symbols
            int firstSymbol = rnd.Next(0, n+1);
            int secondSymbol = rnd.Next(0, n+1);

            // 3rd and 4th
            int thirdSymbol = rnd.Next(97, l + 98);      //(97, 123);
            int fourthSymbol = rnd.Next(97, l + 98);

            // 5th symbol
            tempNumber = firstSymbol > secondSymbol ? firstSymbol : secondSymbol;
            if (firstSymbol == secondSymbol) tempNumber = secondSymbol;
            
            int fifthSymbol = rnd.Next(tempNumber, n + 1);
            string fifthSymbolString = fifthSymbol.ToString();

            string firstSymbolString = firstSymbol.ToString();
            string secondSymbolString = secondSymbol.ToString();


            char character1 = (char) thirdSymbol;
            string thirdSymbolString = character1.ToString();

            char character2 = (char) fourthSymbol;
            string fourthSymbolString = character2.ToString();

            string concatNumberString = firstSymbolString + secondSymbolString + 
                thirdSymbolString + fourthSymbolString + fifthSymbolString;
                
            Console.WriteLine(concatNumberString);
                

        }
    }
}
