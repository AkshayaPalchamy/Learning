namespace EmployeeManagementSystem;

[TestClass]
public class EmployeeServices
{
    [TestMethod]
    public void TestAddEmployee()
    {
        // Arrange
        var service = new EmployeeService();
        var employee = new Employee
        {
            ID = 1,
            Name = "John Doe",
            Age = 30,
            Department = "HR"
        };
        // Act
        service.ADDEmployee(employee);
        // Assert
        Assert.AreEqual(1, service.Employees.Count);
        Assert.AreEqual("John Doe", service.Employees[0].Name);
    }
}