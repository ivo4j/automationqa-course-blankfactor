using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsApp5.Methods
{
    internal class StringReversion
    {
        public string ReturnStringReversed(string myString) 
        {
            if (myString == null) return null;

            string reverseString = string.Empty;
            char[] stringArray = myString.ToCharArray();
            Array.Reverse(stringArray);
            reverseString = new string(stringArray);
            return reverseString;
        }
    }
}
