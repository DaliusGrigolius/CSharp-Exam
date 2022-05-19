using Repository.Models;
using System.Collections.Generic;

namespace Business.Services
{
    public class EmployeeService : IEmployeeService
    {
        public bool Validate(int id, int pinCode, List<Employee> employees)
        {
            return employees.Exists(i => i.Id == id && i.PinCode == pinCode);
        }
    }
}
