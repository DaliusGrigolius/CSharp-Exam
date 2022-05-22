using Repository.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Repository
{
    public class Deserializer : IDeserializer
    {
        public List<Employee> DeserializeEmployees(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            };

            var jsonData = JsonSerializer.Deserialize<List<Employee>>(jsonString, options);

            return jsonData;
        }

        public List<Order> DeserializeTableOrder(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            List<Order> jsonData = JsonSerializer.Deserialize<List<Order>>(jsonString, options);

            return jsonData;
        }
    }
}
