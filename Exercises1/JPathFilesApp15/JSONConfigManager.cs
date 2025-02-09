using JPathFilesApp15.Task2Classes;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPathFilesApp15
{
    internal class JSONConfigManager
    {
        public void DynamicJSONConfigManager()
        {
            ConfigurationManager manager = new ConfigurationManager();
            JObject config = manager.LoadConfig();

            // Display current configuration
            manager.DisplayConfig(config);

            // Toggle a feature flag
            manager.ToggleFeatureFlag(config, "betaFeatures", true);

            // Show all secure API endpoints
            manager.ShowSecureApiEndpoints(config);

            // Add a new API endpoint (ensuring no duplicate name)
            manager.AddApiEndpoint(config, "PaymentService", "https://api.example.com/payments", true);

            // Save updated configuration back to the file
            manager.SaveConfig(config);
        }
    }
}
