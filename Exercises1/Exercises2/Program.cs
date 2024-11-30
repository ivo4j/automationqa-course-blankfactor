using System;
using App2.Conditionals;

public class Program
{
    public static void Main(string[] args)
    {
        int selection = 0;
        do
        {
            Console.WriteLine("Hello, please enter a task number that needs to be executed - between 1 and 5:");
            Console.WriteLine("Task 1: Cinema Hall");
            Console.WriteLine("Task 2: Fishing Trip");
            Console.WriteLine("Task 3: Salary Deduction");
            Console.WriteLine("Task 4: Steps to Reach a Goal");
            Console.WriteLine("Task 5: Birthday Cake");
            Console.WriteLine("Task 6: Password Generator");
            bool res = int.TryParse(Console.ReadLine(), out selection);
        }
        while (selection < 1 || selection > 7);

        switch (selection)
        {

            case 1:
                var firstTask = new CinemaHall(); firstTask.Calculation();
                break;
            case 2:
                var secondTask = new FishingTrip(); secondTask.TripCalculation();
                break;
            case 3:
                var thirdTask = new SalaryDeduction(); thirdTask.SalaryDeduct();
                break;
            case 4:
                var fourthTask = new Steps(); fourthTask.StepsToCountSolution();
                break;
            case 5:
                var fifthTask = new BirthdayCake(); fifthTask.CalculatePieces();
                break;
            case 6:
                var sixthTask = new PasswordGenerator(); sixthTask.Generate();
                break;
            default:
                break;
        }

    }
}

