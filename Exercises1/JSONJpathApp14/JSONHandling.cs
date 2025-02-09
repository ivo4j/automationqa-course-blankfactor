using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONJpathApp14
{
    internal class JSONHandling
    {
        public void DynamicJSONHandling()
        {
            // Original JSON string
            string json = @"
        {
            ""store"": {
                ""products"": [
                    { ""id"": 1, ""name"": ""Laptop"", ""price"": 1200, ""category"": ""Electronics"", ""stock"": 10 },
                    { ""id"": 2, ""name"": ""Tablet"", ""price"": 800, ""category"": ""Electronics"", ""stock"": 0 },
                    { ""id"": 3, ""name"": ""Notebook"", ""price"": 15, ""category"": ""Stationery"", ""stock"": 50 },
                    { ""id"": 4, ""name"": ""Pen"", ""price"": 2, ""category"": ""Stationery"", ""stock"": 100 }
                ],
                ""lastUpdated"": ""2025-01-01T10:00:00Z""
            }
        }";

            // Step 1: Parse JSON into JObject
            JObject storeData = JObject.Parse(json);

            // Step 2: Add a new product
            JObject newProduct = new JObject
            {
                ["id"] = 5,
                ["name"] = "Headphones",
                ["price"] = 150,
                ["category"] = "Electronics",
                ["stock"] = 25
            };

            JArray products = (JArray)storeData["store"]["products"];
            products.Add(newProduct);

            // Step 3: Update stock for Electronics (if stock == 0, set to 50)
            foreach (JObject product in products)
            {
                if ((string)product["category"] == "Electronics" && (int)product["stock"] == 0)
                {
                    product["stock"] = 50;
                }
            }

            // Step 4: Calculate total stock
            int totalStock = products.Sum(p => (int)p["stock"]);
            storeData["store"]["totalStock"] = totalStock;

            // Step 5: Remove products priced below 10
            products = new JArray(products.Where(p => (int)p["price"] >= 10));
            storeData["store"]["products"] = products;

            // Serialize modified JSON and print result
            string updatedJson = JsonConvert.SerializeObject(storeData, Formatting.Indented);
            Console.WriteLine("Modified JSON:\n" + updatedJson);

            // Bonus: Extract "Stationery" products' names and prices
            List<KeyValuePair<string, decimal>> stationeryProducts = ExtractStationeryProducts(storeData);
            Console.WriteLine("\nStationery Products:");
            foreach (var item in stationeryProducts)
            {
                Console.WriteLine($"- {item.Key}: ${item.Value}");
            }
        }

        // Bonus: Extract Stationery product names & prices
        static List<KeyValuePair<string, decimal>> ExtractStationeryProducts(JObject storeData)
        {
            JArray products = (JArray)storeData["store"]["products"];
            return products
                .Where(p => (string)p["category"] == "Stationery")
                .Select(p => new KeyValuePair<string, decimal>((string)p["name"], (decimal)p["price"]))
                .ToList();
        }

    }
}

