using Repository.DataAccess.Interfaces;
using Repository.Models;
using System.Collections.Generic;

namespace Repository.DataAccess
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private List<Employee> Employees { get; }

        public EmployeeRepo(IDeserializer _deserializer, string filePath)
        {
            Employees = _deserializer.DeserializeEmployees(filePath);
        }

        public List<Employee> RetrieveEmployees()
        {
            return Employees;
        }
    }
}
