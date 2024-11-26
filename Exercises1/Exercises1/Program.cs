using System;
using System.ComponentModel.Design;
using App1.Types;

internal class Program
{
    private static void Main(string[] args)
    {

        int selection = 0;
        do
        {
            Console.WriteLine("Hello, please enter a task number that needs to be executed - between 1 and 5:");
            Console.WriteLine("Task 1: Convert and Add Two Numbers");
            Console.WriteLine("Task 2: Format a Full Name");
            Console.WriteLine("Task 3: Extract and Modify Substring");
            Console.WriteLine("Task 4: Calculate the Area of a Circle");
            Console.WriteLine("Task 5: Validate Age Input");
            bool res = int.TryParse(Console.ReadLine(), out selection);
        }
        while (selection < 1 || selection > 6);

        switch (selection)
        {

            case 1:
                var startTask = new ConvertAndAdd(); startTask.Convert();
                break;
            case 2:
                var secondTask = new FormatFullName(); secondTask.Format();
                break;
            case 3:
                var thirdTask = new ModifySubstring(); thirdTask.Modify();
                break;
            case 4:
                var fourthTask = new CalculateArea(); fourthTask.Calculate();
                break;
            case 5:
                var fifthTask = new ValidateAge(); fifthTask.Validate();
                break;
            default:
                break;
        }
    }
}
