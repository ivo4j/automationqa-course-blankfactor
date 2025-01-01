
using App3.Collections;
using CollectionsApp4.Collections;

internal class Program
{
    private static void Main(string[] args)
    {

        int selection = 0;
        do
        {
            Console.WriteLine("Hello, please enter a task number that needs to be executed - between 1 and 5:");
            Console.WriteLine("Task 1: Print Common Elements");
            Console.WriteLine("Task 2: Find the longest sequence of equals");
            Console.WriteLine("Task 3: Print the state of the train");
            Console.WriteLine("Task 4: Cards Game");
            Console.WriteLine("Task 5: Count Characters in a string");
            Console.WriteLine("Task 6: A Miner task");
            Console.WriteLine("Task 7: Basic Stack Operations");
            Console.WriteLine("Task 8: Basic Queue Operations");
            bool res = int.TryParse(Console.ReadLine(), out selection);
        }
        while (selection < 1 || selection > 8);

        switch (selection)
        {

            case 1:
                var startTask = new PrintCommonElements(); startTask.PrintElements();
                break;
            case 2:
                var secondTask = new FindLongestSequenceOfEquals(); secondTask.FindLongestSequence();
                break;
            case 3:
                var thirdTask = new PrintStateOfTrain(); thirdTask.PrintState();
                break;
            case 4:
                var fourthTask = new CardsGame(); fourthTask.FindTheWinner();
                break;
            case 5:
                var fifthTask = new CountCharsInString(); fifthTask.CountChars();
                break;
            case 6:
                var sixthTask = new MinersTask(); sixthTask.CollectAndPrint();
                break;
            case 7:
                var seventhTask = new BasicStackOperations(); seventhTask.StackOperations();
                break;
            case 8:
                var eighthTask = new BasicQuequeOperations();
                eighthTask.QuequeOperations();
                break;
            default:
                break;
        }

    }
}
