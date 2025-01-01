using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3.Collections
{
    internal class PrintStateOfTrain
    {
        public void PrintState()
        {

            // Input: List of wagons
            Console.WriteLine("Enter the initial list of wagons (space-separated integers):");
            List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            // Input: Maximum capacity of each wagon
            Console.WriteLine("Enter the maximum capacity of each wagon:");
            int maxCapacity = int.Parse(Console.ReadLine());

            // Process commands
            Console.WriteLine("Enter commands (type 'end' to finish):");
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command.StartsWith("Add"))
                {
                    // Add a new wagon
                    int passengers = int.Parse(command.Split(' ')[1]);
                    wagons.Add(passengers);
                }
                else
                {
                    // Add passengers to existing wagons
                    int passengersToAdd = int.Parse(command);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengersToAdd <= maxCapacity)
                        {
                            wagons[i] += passengersToAdd;
                            break;
                        }
                    }
                }
            }

            // Output final state of the train
            Console.WriteLine(string.Join(" ", wagons));
        }
    }


}

