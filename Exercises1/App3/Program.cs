
using App3.Collections;

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
            Console.WriteLine("Task 4: Calculate the Area of a Circle");
            Console.WriteLine("Task 5: Validate Age Input");
            bool res = int.TryParse(Console.ReadLine(), out selection);
        }
        while (selection < 1 || selection > 6);

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
                var fifthTask = new MinersTask(); fifthTask.CollectAndPrint();
                break;
                case 6:
                    var sixthTask = new BasicStackOperations(); sixthTask.StackOperations();
                break;
                case 7:

            default:
                break;
        }

    }
}
