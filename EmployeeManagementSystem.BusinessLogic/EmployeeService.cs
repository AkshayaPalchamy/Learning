namespace EmployeeManagementSystem;

public class EmployeeService
{
    public List<Employee> Employees = new();

    public void ADDEmployee(Employee emp)
    {
        Employees.Add(emp);
    }
}