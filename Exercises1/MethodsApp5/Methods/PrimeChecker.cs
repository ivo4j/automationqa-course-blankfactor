using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodsApp5.Methods
{
    internal class PrimeChecker
    {
        public bool IsPrime(int number) 
        {
            if (number <= 1) return false; // Not prime if less than or equal to 1
            if (number == 2) return true; // 2 is prime
            for (int i = 2; i * i <= number; i++) // Start checking from 2
                if (number % i == 0) return false; // Not prime if divisible by any i
            return true; // Return true if it is prime
        }
    }
}
