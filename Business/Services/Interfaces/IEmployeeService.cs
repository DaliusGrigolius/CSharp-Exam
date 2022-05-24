using Repository.Models;
using System.Collections.Generic;

namespace Business.Services.Interfaces
{
    public interface IEmployeeService
    {
        bool Validate(int id, int pinCode, List<Employee> employees);
    }
}