using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPathFilesApp15.Task2Classes
{
    internal class ConfigurationManager
    {
        private const string FilePath = "config.json";

        public JObject LoadConfig()
        {
            if (!File.Exists(FilePath))
            {
                Console.WriteLine("Configuration file not found. Creating a new one...");
                File.WriteAllText(FilePath, "{}"); // Create an empty JSON file if missing
            }

            string json = File.ReadAllText(FilePath);
            return JObject.Parse(json);
        }

        public void SaveConfig(JObject config)
        {
            string json = JsonConvert.SerializeObject(config, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        public void DisplayConfig(JObject config)
        {
            Console.WriteLine("\nCurrent Configuration:");
            Console.WriteLine(config.ToString(Formatting.Indented));
        }

        public void ToggleFeatureFlag(JObject config, string feature, bool enable)
        {
            if (config["featureFlags"]?[feature] != null)
            {
                config["featureFlags"][feature] = enable;
                Console.WriteLine($"\nFeature '{feature}' set to {enable}.");
            }
            else
            {
                Console.WriteLine($"\nFeature '{feature}' not found.");
            }
        }

        public void ShowSecureApiEndpoints(JObject config)
        {
            Console.WriteLine("\nSecure API Endpoints:");
            var secureApis = config["apiEndpoints"]
                             .Where(api => (bool)api["isSecure"])
                             .Select(api => $"{api["name"]}: {api["url"]}");

            foreach (var api in secureApis)
            {
                Console.WriteLine(api);
            }
        }

        public void AddApiEndpoint(JObject config, string name, string url, bool isSecure)
        {
            var apiEndpoints = (JArray)config["apiEndpoints"];

            if (apiEndpoints.Any(api => api["name"].ToString() == name))
            {
                Console.WriteLine($"\nAPI endpoint '{name}' already exists.");
                return;
            }

            var newApi = new JObject
            {
                ["name"] = name,
                ["url"] = url,
                ["isSecure"] = isSecure
            };

            apiEndpoints.Add(newApi);
            Console.WriteLine($"\nAPI '{name}' added successfully.");
        }
    }
}
