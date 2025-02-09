using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONJpathApp14
{
    internal class JPathFiltering
    {
        public void ComplexJPathFiltering()
        {

            // JSON string
            string json = @"
        {
            ""orders"": [
                {
                    ""orderId"": 1,
                    ""customer"": ""John Doe"",
                    ""items"": [
                        { ""product"": ""Laptop"", ""price"": 1200 },
                        { ""product"": ""Mouse"", ""price"": 25 }
                    ]
                },
                {
                    ""orderId"": 2,
                    ""customer"": ""Jane Smith"",
                    ""items"": [
                        { ""product"": ""Phone"", ""price"": 800 },
                        { ""product"": ""Headphones"", ""price"": 100 }
                    ]
                }
            ]
        }";

            // Parse JSON into JObject
            JObject ordersData = JObject.Parse(json);

            // 1. Extract all customers' names
            List<string> customers = ordersData.SelectTokens("$.orders[*].customer")
                                               .Select(c => c.ToString()).ToList();
            Console.WriteLine("Customers:");
            customers.ForEach(Console.WriteLine);

            // 2. Find all products with a price greater than 100
            List<string> expensiveProducts = ordersData.SelectTokens("$.orders[*].items[?(@.price > 100)].product")
                                                       .Select(p => p.ToString()).ToList();
            Console.WriteLine("\nProducts with price > 100:");
            expensiveProducts.ForEach(Console.WriteLine);

            // 3. Extract the total price of items in the first order
            decimal totalFirstOrder = ordersData.SelectTokens("$.orders[0].items[*].price")
                                                .Sum(p => (decimal)p);
            Console.WriteLine($"\nTotal price of items in first order: ${totalFirstOrder}");
        }
    }
}
