using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Types
{
    /*  Task 3: Extract and Modify Substring
Objective: Given a string with a sentence, extract a word (substring) from it and convert it to uppercase.
Instructions: Use methods like Substring() and ToUpper(). */
    public class ModifySubstring
    {
        public void Modify()
        {
            string MyString = "This sentence contains a text and needs to be extracted.";
            string MySubstring = MyString.Substring(25, 4);

            Console.WriteLine($"The extracted string is " + MySubstring.ToUpper());
        }
    }
}
