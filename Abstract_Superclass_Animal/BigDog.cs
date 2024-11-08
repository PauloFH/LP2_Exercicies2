namespace Abstract_Superclass_Animal;

public class BigDog : Dog {
    public override void greeting() {
        Console.WriteLine("Woow!");
    }


    public override void greeting(Dog another) {
        Console.WriteLine("Woooooowwwww!");
    }
}
