using Repository.Models;
using System.Collections.Generic;

namespace Repository.DataAccess.Interfaces
{
    public interface IEmployeeRepo
    {
        List<Employee> RetrieveEmployees();
    }
}