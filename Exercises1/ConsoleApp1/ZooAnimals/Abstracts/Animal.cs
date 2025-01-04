using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAbstractionApp9.ZooAnimals.Abstracts
{
    public abstract class Animal
    {
        // Field
        public string Name { get; set; }

        // Constructor
        protected Animal(string name)
        {
            Name = name;
        }

        // Abstract method to be implemented by derived classes
        public abstract void MakeSound();

        // Concrete method
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }
}
