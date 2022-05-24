using Repository;
using Repository.DataAccess;
using Repository.DataAccess.Interfaces;
using Xunit;

namespace XUnit_Tests.RepositoryDataAccessTests
{
    public class EmployeeRepoTest
    {
        [Fact]
        public void RetrieveEmployees_HasData_ReturnsMoreThanZeroEmployees()
        {
            var employeesFilePath = @"..\..\..\..\DataFiles\Employees.json";
            IEmployeeRepo _employeeRepo = new EmployeeRepo(new Deserializer(), employeesFilePath);
            var employees = _employeeRepo.RetrieveEmployees();

            Assert.NotNull(employees);
        }
    }
}
