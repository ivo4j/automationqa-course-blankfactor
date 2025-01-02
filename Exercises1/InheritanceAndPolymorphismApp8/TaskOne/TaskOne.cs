using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismApp8.TaskOne
{
    internal class TaskOne
    {
        public void InheritOne()
        {
            // Create a Dog object
            Dog dog = new Dog();

            // Call methods from Dog and its base class Animal
            dog.Bark(); // Prints: barking...
            dog.Eat();  // Prints: eating...
        }
    }
}
