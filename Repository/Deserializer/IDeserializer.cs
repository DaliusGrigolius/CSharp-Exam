using Repository.Models;
using System.Collections.Generic;

namespace Repository
{
    public interface IDeserializer
    {
        List<Employee> DeserializeEmployees(string filePath);
        List<Order> DeserializeTableOrder(string filePath);
    }
}