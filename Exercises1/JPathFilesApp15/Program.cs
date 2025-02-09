namespace JPathFilesApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please select the number of the task to be executed: 1 - 4!");
            Console.WriteLine("1. Task 1: Product Inventory Management");
            Console.WriteLine("2. Task 2: Dynamic JSON Configuration Manager");
            Console.WriteLine("3. Task 3: Merge Two JSON Files");
            Console.WriteLine("4. Task 4: Split a JSON File by Key");
            bool res = int.TryParse(Console.ReadLine(), out int selection);

            switch (selection)
            {

                case 1:
                    var firstTask = new ProductInventoryManagement();
                    firstTask.ProductInventoryMnmnt();
                    break;
                case 2:
                    var secondTask = new JSONConfigManager();
                    secondTask.DynamicJSONConfigManager();
                    break;
                case 3:
                    var thirdTask = new MergeJSONFiles();
                    thirdTask.MergeTwoJSONFiles();
                    break;
                case 4:
                    var fourthTask = new SplitJSONFile();
                    fourthTask.SplitJSONFileByKey();
                    break;
            }
        }
    }
}
