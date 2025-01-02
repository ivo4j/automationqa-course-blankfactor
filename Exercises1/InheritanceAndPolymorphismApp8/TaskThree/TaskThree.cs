using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismApp8.TaskThree
{
    internal class TaskThree
    {

        public void InheritThree()
        {
            // Create a Dog object
            Dog dog = new Dog();
            dog.Eat();  // From Animal
            dog.Bark(); // From Dog

            // Create a Cat object
            Cat cat = new Cat();
            cat.Eat();  // From Animal
            cat.Meow(); // From Cat
        }
    }
}
