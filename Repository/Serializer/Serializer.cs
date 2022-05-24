using Repository.Models;
using Repository.Models.Cheques;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Repository.Serializer
{
    public class Serializer : ISerializer
    {
        public void WriteOrderDataToFile(List<Order> ordersList, string filePath)
        {
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            }

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(ordersList, options);
            File.WriteAllText(filePath, jsonString);
        }
        
        public void WriteChequePaymentWithCardToFile(List<CustomerChequePaymentWithCard> chequePaymentWithCardList, string filePath)
        {
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            }

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(chequePaymentWithCardList, options);
            File.WriteAllText(filePath, jsonString);
        }

        public void WriteChequePaymentWithCashToFile(List<CustomerChequePaymentWithCash> chequePaymentWithCashList, string filePath)
        {
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            }

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(chequePaymentWithCashList, options);
            File.WriteAllText(filePath, jsonString);
        }
    }
}
