using Repository.Models;
using System.Collections.Generic;

namespace Business.Services
{
    public interface IEmployeeService
    {
        bool Validate(int id, int pinCode, List<Employee> employees);
    }
}