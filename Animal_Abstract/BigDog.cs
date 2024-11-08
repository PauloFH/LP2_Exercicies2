namespace Animal_Abstract;

public class BigDog : Dog{
    public BigDog(string name): base(name) {
    }
    public override void Greets()
    {
        Console.WriteLine("Wooow");
    }

   
    public override void Greets(Dog another)
    {
        Console.WriteLine("Woooooow");
    }

    public void Greets(BigDog anotherDog) {
        Console.WriteLine("Wooooooooow");
    }
    public override string ToString() {
        return $"Big Dog:[ {Name} ]";
    }
    
}
