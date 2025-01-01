using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp7.ExceptionHandling
{
    internal class CustomException
    {
        /// <summary>
        /// Validates the age and throws an exception if invalid.
        /// </summary>
        /// <param name="age">Age to validate.</param>
        /// <returns>Returns a string indicating the age is valid.</returns>
        public string ValidateAge(int age)
        {
            if (age < 0 || age > 150)
            {
                throw new InvalidAgeException($"Invalid age: {age}. Age must be between 0 and 150.");
            }
            return "Age is valid";
        }
    }
}
