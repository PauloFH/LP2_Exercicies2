namespace HCA;

public abstract class User {
    public string name { get; set; }
    public string password { get; set; }
    public  User(string name, string password) {
        this.name = name;
        this.password = password.GetHashCode().ToString();
    }
    public abstract void login(string username, string password);
}

public class Employee : User {
    private string position;
    public Employee(string position, string name, string password): base(name, password) {
        this.position = position;
    }
    public override string ToString() {
        return $"Employee[position={position}, name={name}, encrypted password={password}]";
    }
    public override void login(string username, string password) {
        if (username == this.name && password.GetHashCode().ToString()== this.password) {
            Console.WriteLine("login success");
        }
        else {
            Console.WriteLine("login failed");
        }
    }
}
