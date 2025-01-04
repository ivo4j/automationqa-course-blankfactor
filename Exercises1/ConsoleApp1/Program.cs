using EncapsulationAbstractionApp9.AdvancedLibraryMS;
using EncapsulationAbstractionApp9.ECommerceSystem;
using EncapsulationAbstractionApp9.SchoolGradingSystem;
using EncapsulationAbstractionApp9.ZooAnimals;

namespace EncapsulationAbstractionApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int selection = 0;
                do
                {
                    Console.WriteLine("Hello, please enter a task number that needs to be executed - between 1 and 5:");
                    Console.WriteLine("Task 1: Zoo Animals");
                    Console.WriteLine("Task 2: Puppy class inherits from Dog which inherits from Animal class");
                    Console.WriteLine("Task 3: Cat and Dog each inherit from Animal ");
                    Console.WriteLine("Task 4: Math operations - 3 Add() methods");
                    
                    bool res = int.TryParse(Console.ReadLine(), out selection);
                }
                while (selection < 1 || selection > 4);

                switch (selection)
                {

                    case 1:
                        var firstTask = new TaskOne();
                        firstTask.TaskOneStart();
                        break;
                    case 2:
                        var secondTask = new TaskTwo();
                        secondTask.TaskTwoStart();
                        break;
                    case 3:
                        var thirdTask = new TaskThree();
                        thirdTask.TaskThreeStart();
                        break;
                    case 4:
                        var fourthTask = new TaskFour();
                        fourthTask.TaskFourStart();
                        break;
                    
                    default:
                        break;
                }
            }
        }
    }
