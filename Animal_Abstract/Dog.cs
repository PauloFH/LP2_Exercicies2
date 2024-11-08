namespace Animal_Abstract;

public class Dog : Animal{
    
    public Dog(string name) :base(name){}
    
    public override void Greets() {
        Console.WriteLine("Woof");
    }
    public virtual void Greets(Dog another) {
        Console.WriteLine("Woooof");
    }
    public override string ToString() {
        return $"Dog:[ {Name} ]";
    }

}
