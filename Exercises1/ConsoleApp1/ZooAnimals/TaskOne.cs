using EncapsulationAbstractionApp9.ZooAnimals.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAbstractionApp9.ZooAnimals
{
    internal class TaskOne
    {
        public void TaskOneStart()
        {
            // Create a list of animals
            List<Animal> animals = new List<Animal>
            {
                new Dog("Buddy"),
                new Cat("Whiskers"),
                new Dog("Max"),
                new Cat("Luna")
            };

            // Call MakeSound() and Eat() for each animal
            foreach (var animal in animals)
            {
                animal.MakeSound();
                animal.Eat();
            }
        }
    }
}
