﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises1.Lecture2
{
    internal class ModifySubstring
    {

        static void Main()
        {
            string MyString = "This sentence contains a text and needs to be extracted.";
            string MySubstring = MyString.Substring(25, 4);

            Console.WriteLine($"The extracted string is " + MySubstring.ToUpper());



        }
    }
}