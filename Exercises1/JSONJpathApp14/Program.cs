namespace JSONJpathApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Hello, please select the number of the task to be executed: !");
            Console.WriteLine("1. Task 1: Parse and Extract Data");
            Console.WriteLine("2. Task 2: Complex Object Serialization and Deserialization");
            Console.WriteLine("3. Task 3: Dynamic JSON Handling");
            Console.WriteLine("4. Task 4: Complex JPath Filtering");
            Console.WriteLine("5. Task 5: Advanced Serialization with Custom Converters");
            bool res = int.TryParse(Console.ReadLine(), out int selection);

            switch (selection)
            {

                case 1:
                    var firstTask = new ParseAndExtractData();
                    firstTask.ParseAndExtract();
                    break;
                case 2:
                    var secondTask = new ObjectSerialization();
                    secondTask.ObjectSerializationAndDeserialization();
                    break;
                case 3:
                    var thirdTask = new JSONHandling();
                    thirdTask.DynamicJSONHandling();
                    break;
                case 4:
                    var fourthTask = new JPathFiltering();
                    fourthTask.ComplexJPathFiltering();
                    break;
                case 5:
                    var fifthTask = new AdvancedSerialization();
                    fifthTask.AdvancedSerializationWithCustomConverters();
                    break;
            }
        }
    }
}
