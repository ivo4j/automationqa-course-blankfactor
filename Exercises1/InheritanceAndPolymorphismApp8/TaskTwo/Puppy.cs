using InheritanceAndPolymorphismApp8.TaskOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismApp8.TaskTwo
{
    internal class Puppy : Dog
    {
        // Public method in Puppy class
        public void Weep()
        {
            Console.WriteLine("weeping...");
        }
    }
}
