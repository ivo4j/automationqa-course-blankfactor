using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3.Collections
{
    internal class MinersTask
    {
        public void CollectAndPrint()
        {
            Dictionary<string, long> resources = new Dictionary<string, long>();
            string input;

            while ((input = Console.ReadLine()) != "stop")
            {
                string resource = input;
                long quantity = long.Parse(Console.ReadLine());

                if (resources.ContainsKey(resource))
                {
                    resources[resource] += quantity;
                }
                else
                {
                    resources[resource] = quantity;
                }
            }

            foreach (var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
