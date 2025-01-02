using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismApp8.TaskFive
{
    internal class TaskFive
    {
        public void InheritFive()
        {
            // Create instances of Cat and Dog
            Animal cat = new Cat("Maria", "Whiskas");
            Animal dog = new Dog("Rex", "Meat");

            // Output their explanation
            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}
