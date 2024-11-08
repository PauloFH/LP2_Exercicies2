namespace Animal_Abstract;

class Program
{
    static void Main(string[] args)
    {
        Cat cat = new Cat("Batman");
        Console.WriteLine(cat);
        cat.Greets();
        Dog dog = new Dog("Kratos");
        Console.WriteLine(dog);
        dog.Greets();
        Dog dog2 = new Dog("Rex");
        Console.WriteLine(dog2);
        dog2.Greets(dog);
        
        BigDog bigDog = new BigDog("Princess");
        Console.WriteLine(bigDog);
        bigDog.Greets();
        bigDog.Greets(dog2);
        BigDog bigDog2 = new BigDog("Cutie");
        Console.WriteLine(bigDog2);
        bigDog2.Greets(bigDog);
        
    }
}
