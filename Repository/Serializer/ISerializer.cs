using Repository.Models;
using System.Collections.Generic;

namespace Repository.Serializer
{
    public interface ISerializer
    {
        void WriteOrderDataToFile(List<Order> productsList, string filePath);
    }
}