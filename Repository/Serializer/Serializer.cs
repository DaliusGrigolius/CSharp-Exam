using Repository.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Repository.Serializer
{
    public class Serializer : ISerializer
    {
        public void WriteOrderDataToFile(List<Order> productsList, string filePath)
        {
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            }

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(productsList, options);
            File.WriteAllText(filePath, jsonString);
        }
    }
}
