using System;

class StringToInteger {

    static void Main()
    {
        int num1, num2, sum = 0;
        
        // Task 1: Convert and Add Two Numbers:  Prompt the user to input two numbers as strings, convert them to integers, and display their sum

        Console.WriteLine("Hello, please enter a number:");
        string string1 = Console.ReadLine();
        bool res1 = Int32.TryParse(string1,out num1);

        Console.WriteLine("Hello, please enter a second number:");
        string string2 = Console.ReadLine();
        bool res2 = Int32.TryParse(string2,out num2);
        
        sum = num1 + num2;
        Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
    }
}