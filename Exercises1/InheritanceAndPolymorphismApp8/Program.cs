using InheritanceAndPolymorphismApp8.TaskFour;
using InheritanceAndPolymorphismApp8.TaskOne;
using System.Reflection.PortableExecutable;

namespace InheritanceAndPolymorphismApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int selection = 0;
            do
            {
                Console.WriteLine("Hello, please enter a task number that needs to be executed - between 1 and 5:");
                Console.WriteLine("Task 1: Dog class inherits Animal class");
                Console.WriteLine("Task 2: Puppy class inherits from Dog which inherits from Animal class");
                Console.WriteLine("Task 3: Cat and Dog each inherit from Animal ");
                Console.WriteLine("Task 4: Math operations - 3 Add() methods");
                Console.WriteLine("Task 5: Animal class with one virtual method overriden in Cat and Dog classes");

                bool res = int.TryParse(Console.ReadLine(), out selection);
            }
            while (selection < 1 || selection > 5);

            switch (selection)
            {

                case 1:
                    var firstTask = new TaskOne.TaskOne();
                    firstTask.InheritOne();
                    break;
                case 2:
                    var secondTask = new TaskTwo.TaskTwo();
                    secondTask.InheritTwo();
                    break;
                case 3:
                    var thirdTask = new TaskThree.TaskThree();
                    thirdTask.InheritThree();
                    break;
                case 4:
                    // Create an instance of MathOperations
                    MathOperations mo = new MathOperations();

                    // Test the Add methods
                    Console.WriteLine(mo.Add(2, 3));                 // Output: 5
                    Console.WriteLine(mo.Add(2.2, 3.3, 5.5));        // Output: 11
                    Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));     // Output: 9.9
                    break;
                case 5:
                    var fifthTask = new TaskFive.TaskFive();
                    fifthTask.InheritFive();
                    break;

                default:
                    break;
            }
        }
    }
}


