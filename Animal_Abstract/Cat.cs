using System.Threading.Channels;

namespace Animal_Abstract;

public class Cat : Animal{
    public Cat(string name) : base(name) {
    }
    public override void Greets() {
        Console.WriteLine("Meow");
    }
    public override string ToString() {
        return $"Cat:[ {Name} ]";
    }
}
