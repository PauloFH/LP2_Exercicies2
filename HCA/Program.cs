namespace HCA;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Herança:");
        User worker = new Employee("worker", "gustas", "123456");
        Console.WriteLine(worker.ToString());
        worker.login("gustas", "123456");
        Console.WriteLine();
        Console.WriteLine("Composição:");
        Notebook notebook = new Notebook("Dell", "Intel i7");
        Console.WriteLine(notebook.ToString());
        Console.WriteLine();
        Console.WriteLine("Agregação:");
        Department department = new Department("TI");
        Employee emp1 = new Employee("Dev front","Alice", "Alice123");
        Employee emp2 = new Employee("Dev Back","Bob", "Bob123");
        department.AddEmployee(emp1);
        department.AddEmployee(emp2);
        department.ListEmployees();
    }
}
