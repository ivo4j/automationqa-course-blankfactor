using JSONJpathApp14.Task5Classes;
using Newtonsoft.Json;

namespace JSONJpathApp14
{
    internal class AdvancedSerialization
    {
        public void AdvancedSerializationWithCustomConverters()
        {
            // Create a list of events
            List<Event> events = new List<Event>
        {
            new Event { Date = new DateTime(2024, 2, 10), Name = "Conference" },
            new Event { Date = new DateTime(2024, 5, 20), Name = "Workshop" }
        };

            // Serialize with custom converter
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                Converters = new List<JsonConverter> { new CustomDateConverter() },
                Formatting = Formatting.Indented
            };

            string json = JsonConvert.SerializeObject(events, settings);
            Console.WriteLine("Serialized JSON:\n" + json);

            // Deserialize the JSON back into Event objects
            List<Event> deserializedEvents = JsonConvert.DeserializeObject<List<Event>>(json, settings);

            // Print event details
            Console.WriteLine("\nDeserialized Events:");
            foreach (var evt in deserializedEvents)
            {
                Console.WriteLine($"Event: {evt.Name}, Date: {evt.Date:yyyy-MM-dd}");
            }
        }
    }
}