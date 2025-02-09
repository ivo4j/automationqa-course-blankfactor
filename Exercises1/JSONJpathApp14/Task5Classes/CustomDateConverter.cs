using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONJpathApp14.Task5Classes
{
    internal class CustomDateConverter : JsonConverter<DateTime>
    {
        private const string Format = "yyyy-MM-dd";

        public override void WriteJson(JsonWriter writer, DateTime value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString(Format, CultureInfo.InvariantCulture));
        }

        public override DateTime ReadJson(JsonReader reader, Type objectType, DateTime existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return DateTime.ParseExact((string)reader.Value, Format, CultureInfo.InvariantCulture);
        }
    }
}
