using EncapsulationAbstractionApp9.ZooAnimals.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAbstractionApp9.ZooAnimals
{
    internal class Cat : Animal
    {
        // Constructor
        public Cat(string name) : base(name) { }

        // Implementation of abstract method
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
