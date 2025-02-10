using JPathFilesApp15.Task3Files;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPathFilesApp15
{
    internal class MergeJSONFiles
    {

        // C:\Users\ivayl\source\repos\ivo4j\automationqa-course-blankfactor\Exercises1\JPathFilesApp15\Task3Files\products1.json
       /* string relativePath1 = Path.Combine("Task3Files", "products1.json");
        string relativePath2 = Path.Combine("Task3Files", "products2.json"); */

        private static readonly string File1 = Path.Combine("Task3Files", "products1.json");
        private static readonly string File2 = Path.Combine("Task3Files", "products2.json");
        private const string MergedFile = "mergedProducts.json";
        public void MergeTwoJSONFiles()
        {
            // Load the two JSON files
            List<Product> products1 = LoadJson(File1);
            List<Product> products2 = LoadJson(File2);

            // Merge the products (override duplicates with products2)
            Dictionary<int, Product> mergedProducts = products1
                .Concat(products2)
                .ToDictionary(p => p.Id, p => p);

            // Save the merged list to a new file
            SaveJson(mergedProducts.Values.ToList(), MergedFile);

            // Display the merged results
            Console.WriteLine("\nMerged Products:");
            foreach (var product in mergedProducts.Values)
            {
                Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }
        }

        static List<Product> LoadJson(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File {filePath} not found.");
                return new List<Product>();
            }

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Product>>(json) ?? new List<Product>();
        }

        static void SaveJson(List<Product> products, string filePath)
        {
            string json = JsonConvert.SerializeObject(products, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
