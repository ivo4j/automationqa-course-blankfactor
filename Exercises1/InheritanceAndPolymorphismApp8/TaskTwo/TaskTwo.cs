using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismApp8.TaskTwo
{
    internal class TaskTwo
    {
        public void InheritTwo() 
        {
            // Create a Puppy object
            Puppy puppy = new Puppy();

            // Call methods from Puppy and inherited classes
            puppy.Eat();  // From Animal
            puppy.Bark(); // From Dog
            puppy.Weep(); // From Puppy
        }
    }
}
