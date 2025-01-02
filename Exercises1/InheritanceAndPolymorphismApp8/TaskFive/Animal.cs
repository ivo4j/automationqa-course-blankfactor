using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismApp8.TaskFive
{
    internal class Animal
    {
        // Fields
        public string Name { get; set; }
        public string FavouriteFood { get; set; }

        // Constructor
        public Animal(string name, string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }

        // Virtual method to be overridden in derived classes
        public virtual string ExplainSelf()
        {
            return $"I am {Name} and my favourite food is {FavouriteFood}";
        }
    }
}
