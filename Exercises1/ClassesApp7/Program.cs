using ClassesApp7.Classes;
using ClassesApp7.ExceptionHandling;

namespace ClassesApp7
{
    internal class Program
    {

        private static void Main(string[] args)
        {

            int selection = 0;
            do
            {
                Console.WriteLine("Hello, please enter a task number that needs to be executed - between 1 and 5:");
                Console.WriteLine("Task 1: Create a Product class");
                Console.WriteLine("Task 2: Bank Account class");
                Console.WriteLine("Task 3: Division calculator");
                Console.WriteLine("Task 4: Custom exception");
                Console.WriteLine("Task 5: File Reader with cleanup");
               
                bool res = int.TryParse(Console.ReadLine(), out selection);
            }
            while (selection < 1 || selection > 5);

            switch (selection)
            {

                case 1:
                    // Create a product using the default constructor
                    Product defaultProduct = new Product();
                    Console.WriteLine($"Default Product: Name = {defaultProduct.Name}, Price = {defaultProduct.Price}, Quantity = {defaultProduct.Quantity}");

                    // Create a product using the parameterized constructor
                    Product specificProduct = new Product("Laptop", 999.99m, 5);
                    Console.WriteLine($"Specific Product: Name = {specificProduct.Name}, Price = {specificProduct.Price}, Quantity = {specificProduct.Quantity}");
                    Console.WriteLine($"Total Cost of {specificProduct.Name}: {specificProduct.CalculateTotalCost()}");
                    break;
                case 2:
                    try
                    {
                        // Create a new bank account
                        BankAccount account = new BankAccount("123456789", 1000.00m);
                        Console.WriteLine($"Account {account.AccountNumber} created with initial balance of {account.Balance:C}.");

                        // Deposit money
                        account.Deposit(500.00m);

                        // Withdraw money
                        account.Withdraw(300.00m);

                        // Attempt to withdraw more than the balance
                        account.Withdraw(1500.00m);
                    }
                    catch (InsufficientFundsException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    break;
                case 3:
                    var thirdTask = new DivisionCalculator();
                    thirdTask.Divide();
                    break;
                case 4:
                    Console.WriteLine("Age Validation Test");

                    // Test the ValidateAge method with various inputs
                    int[] testAges = { 25, -5, 151, 0, 150, 45 };

                    foreach (var age in testAges)
                    {
                        try
                        {
                            Console.WriteLine($"Testing age: {age}");
                            var fourthTask = new CustomException();
                            string result = fourthTask.ValidateAge(age);
                            Console.WriteLine(result);
                        }
                        catch (InvalidAgeException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }
                    break;
                case 5:
                    Console.WriteLine("File Reader with Cleanup");

                    // Create a mock file for testing
                    string mockFilePath = "mockfile.txt";
                    File.WriteAllText(mockFilePath, "This is a test file. It contains some text for demonstration.");

                    var fifthTask = new FReader();
                    // Test with a valid file path
                    Console.WriteLine("\nTesting with a valid file path:");
                    fifthTask.ReadFile(mockFilePath);

                    // Test with an invalid file path
                    Console.WriteLine("\nTesting with an invalid file path:");
                    fifthTask.ReadFile("nonexistentfile.txt");
                    break;
               
                default:
                    break;
            }
        }
    }
}
