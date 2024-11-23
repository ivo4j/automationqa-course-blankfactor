using System;
using Type;


static void Main() 
{ 

    Console.WriteLine("Hello, please enter a task number that needs to be executed - between 1 and 5:");
    Console.WriteLine("Task 1: Convert and Add Two Numbers");
    Console.WriteLine("Task 2: Format a Full Name");
    Console.WriteLine("Task 3: Extract and Modify Substring");
    Console.WriteLine("Task 4: Calculate the Area of a Circle");
    Console.WriteLine("Task 5: Validate Age Input");

    bool res = int.TryParse(Console.ReadLine(), out int selection); 

    switch (selection) {

        case 1: var startConvert = new ConvertAndAdd(); startConvert.Convert ();
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        default:
        break;
    }
}