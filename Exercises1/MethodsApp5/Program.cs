using MethodsApp5.Methods;

internal class Program
{
    private static void Main(string[] args)
    {

        int selection = 0;
        do
        {
            Console.WriteLine("Hello, please enter a task number that needs to be executed - between 1 and 5:");
            Console.WriteLine("Task 1: Find the largest element");
            Console.WriteLine("Task 2: Reverse a string");
            Console.WriteLine("Task 3: Calculate the Fibonacci number");
            Console.WriteLine("Task 4: Check a number for prime");
            Console.WriteLine("Task 5: Order an array of integers in ascending order");
            bool res = int.TryParse(Console.ReadLine(), out selection);
        }
        while (selection < 1 || selection > 6);

        switch (selection)
        {

            case 1:
                Console.WriteLine("Enter a sequence of numbers:");
                string input = Console.ReadLine();
                string[] formattedInput = input.Split();
                int[] numbers = Array.ConvertAll(formattedInput, int.Parse);
                var startTask = new FindLargest();
                Console.WriteLine(startTask.FindLargestNumber(numbers));
                break;
            case 2:
                Console.WriteLine("Enter a string:");
                string myInput = Console.ReadLine();
                var secondTask = new StringReversion();
                Console.WriteLine(secondTask.ReturnStringReversed(myInput));
                break;
            case 3:
                Console.WriteLine("Enter the first n of numbers of Fibonacci:");
                string fibNumberString = Console.ReadLine();
                int fibNumber = int.Parse(fibNumberString);
                var thirdTask = new FibonacchiNumberCalculation; 
                Console.WriteLine(thirdTask.CalculateFibNumber(fibNumber));
                break;
            case 4:
                Console.WriteLine("Enter a number to check for prime:");
                string primeString = Console.ReadLine();
                int primeNumber = int.Parse(primeString);
                var fourthTask = new PrimeChecker(); 
                bool result = fourthTask.IsPrime(primeNumber);
                if (result) Console.WriteLine($"Number {primeNumber} is a prime!");
                else Console.WriteLine($"Number {primeNumber} is not a prime!");
                break;
            case 5:
                Console.WriteLine("Enter a sequence of unordered integer numbers:");
                string unsortedInput = Console.ReadLine();
                string[] formattedUnsorted = unsortedInput.Split();
                int[] intUnordered = Array.ConvertAll(formattedUnsorted, int.Parse);
                var fifthTask = new SortArrayAscending();
                int[] intOrdered = fifthTask.SortAscending(intUnordered);
                Console.WriteLine($"Ordered array: {intOrdered.ToString()}");
                break;
            case 6:
                //var sixthTask = new BasicStackOperations(); sixthTask.StackOperations();
                break;
            case 7:

            default:
                break;
        }

    }
}