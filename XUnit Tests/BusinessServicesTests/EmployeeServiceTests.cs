using Business.Services;
using Business.Services.Interfaces;
using Repository;
using Repository.DataAccess;
using Repository.DataAccess.Interfaces;
using Xunit;

namespace XUnit_Tests.BusinessServicesTests
{
    public class EmployeeServiceTests
    {
        [Fact]
        public void Validate_EmployeeExists_ReturnsTrue()
        {
            var employeesFilePath = @"..\..\..\..\DataFiles\Employees.json";
            IEmployeeService _service = new EmployeeService();
            IEmployeeRepo _employeeRepo = new EmployeeRepo(new Deserializer(), employeesFilePath);
            var employees = _employeeRepo.RetrieveEmployees();

            bool result = _service.Validate(112233, 1234, employees);
            
            Assert.True(result);
        }

        [Fact]
        public void Validate_EmployeeExists_ReturnsFalse()
        {
            var employeesFilePath = @"..\..\..\..\DataFiles\Employees.json";
            IEmployeeService _service = new EmployeeService();
            IEmployeeRepo _employeeRepo = new EmployeeRepo(new Deserializer(), employeesFilePath);
            var employees = _employeeRepo.RetrieveEmployees();

            bool result = _service.Validate(112232, 1234, employees);

            Assert.False(result);
        }
    }
}
