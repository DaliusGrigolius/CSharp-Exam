using Repository.Models;
using System.Collections.Generic;

namespace Repository.DataAccess
{
    public interface IEmployeeRepo
    {
        List<Employee> RetrieveEmployees();
    }
}