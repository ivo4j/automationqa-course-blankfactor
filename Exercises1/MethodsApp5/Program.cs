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
            Console.WriteLine("Task 6. Swap two integer numbers");
            Console.WriteLine("Task 7. Update array elements");
            Console.WriteLine("Task 8. Divide two integers");
            Console.WriteLine("Task 9. Parse string to number");
            bool res = int.TryParse(Console.ReadLine(), out selection);
        }
        while (selection < 1 || selection > 9);

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
                var thirdTask = new FibonacchiNumberCalculation();
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
                //Console.WriteLine("Enter a sequence of unordered integer numbers separated by comma:");
                //string unsortedInput = Console.ReadLine();
                //string[] formattedUnsorted = unsortedInput.Split(',');
                //int[] intUnordered = Array.ConvertAll(formattedUnsorted, int.Parse);
                var fifthTask = new SortArrayAscending();
                int[] intUnordered = SortArrayAscending.EnterAndConvertNumbers();
                 int[] intOrdered = fifthTask.SortAscending(intUnordered);
                Console.WriteLine("Ordered array: \n");
                foreach (int number in intOrdered)
                {
                    Console.Write(number + " ");
                }
                break;
            case 6:
                Console.WriteLine("Please enter the first number: ");
                int firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second number: ");
                int secondNumber = int.Parse(Console.ReadLine());

                Console.WriteLine($"Before swapping: first number: {firstNumber}, second number {secondNumber}");
                var sixthTask = new SwapTwoNumbers(); sixthTask.SwapTheNumbers(ref firstNumber, ref secondNumber);
                Console.WriteLine($"After swapping: first number: {firstNumber}, second number {secondNumber}");
                break;
            case 7:
                Console.WriteLine("Enter a sequence of integer numbers:");
                string stringInput = Console.ReadLine();
                string[] unsorted = stringInput.Split();
                int[] intArray = Array.ConvertAll(unsorted, int.Parse);
                Console.WriteLine("Enter the multiplication factor: ");
                int factor = int.Parse(Console.ReadLine());

                var seventhTask = new UpdateArrayElements();
                seventhTask.UpdateArray(ref intArray, factor);

                seventhTask.PrintArray(intArray);
                break;
            case 8:
                Console.WriteLine("Please enter the first integer - the dividend:");
                int dividend = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second integer - the divisor:");
                int divisor = int.Parse(Console.ReadLine());
                if (divisor == 0)
                {
                    Console.WriteLine("The divisor cannot be 0");
                    return;
                }

                var eighthTask = new DivideTwoNumbers();
                eighthTask.DivideTheNumbers(dividend, divisor, out int quotient, out int remainder);

                Console.WriteLine($"Quotient: {quotient}");
                Console.WriteLine($"Remainder: {remainder}");
                break;
            case 9:
                Console.WriteLine("Please enter a string to be parsed to number: ");
                string stringToNumber = Console.ReadLine();

                var ninthTask = new ParseStringToNumber();
                int resultInt = ninthTask.TryConvertString(stringToNumber);

                if (resultInt == 0) Console.WriteLine($"{stringToNumber} cannot be parsed to number");
                else Console.WriteLine($"{resultInt} is parsed to number!");
                break;
            default:
                break;
        }

    }
}