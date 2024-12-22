using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsApp5.Methods
{
    internal class ParseStringToNumber
    {
        public int TryConvertString(string input)
        {
            if (int.TryParse(input, out int result))
            {
                return result; // Return the parsed integer if successful
            }
            else
            {
                return 0; // Return 0 if the conversion fails
            }
        }

    }
}

