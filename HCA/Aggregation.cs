namespace HCA;


public class Department {
    private string _name;
    public string Name => _name;
    private List<Employee> _employees;

    public Department(string name) {
        _name = name;
        _employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee) {
        _employees.Add(employee);
    }

    public void ListEmployees() {
        Console.WriteLine($"Employees in {Name} Department:");
        foreach (var employee in _employees) {
            Console.WriteLine(employee.ToString());
        }
    }
}
