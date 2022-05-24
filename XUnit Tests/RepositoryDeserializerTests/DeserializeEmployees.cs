using Repository;
using Xunit;

namespace XUnit_Tests.RepositoryDeserializerTests
{
    public class DeserializeEmployees
    {
        [Fact]
        public void DeserializeEmployees_HasData_ReturnsEmployeesListCountMoreThanZero()
        {
            IDeserializer deserializer = new Deserializer();
            var employeesFilePath = @"..\..\..\..\DataFiles\Employees.json";
            var employeesList = deserializer.DeserializeEmployees(employeesFilePath);

            Assert.True(employeesList.Count > 0);
        }
    }
}
