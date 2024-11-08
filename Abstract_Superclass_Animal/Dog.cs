namespace Abstract_Superclass_Animal;

public class Dog : Animal {
    public virtual void greeting(Dog another) {
        Console.WriteLine("Woooooooooof!");
    }
    public override void greeting() {
        Console.WriteLine("Woof!");
    }
}
