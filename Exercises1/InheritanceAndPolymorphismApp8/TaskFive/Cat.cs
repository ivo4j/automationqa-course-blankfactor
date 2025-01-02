using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismApp8.TaskFive
{
    internal class Cat : Animal
    {
        // Constructor
        public Cat(string name, string favouriteFood) : base(name, favouriteFood) { }

        // Override ExplainSelf method
        public override string ExplainSelf()
        {
            return base.ExplainSelf() + "\nMEEOW";
        }
    }
}
