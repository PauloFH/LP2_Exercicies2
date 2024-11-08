namespace Animal_Abstract;

public abstract class Animal {
    private readonly string _name;
    public string Name => _name;
    public Animal(string name) {
        _name = name;
    }
    public abstract void Greets();

    public override string ToString() {
        return $"Animal:[ {Name} ]";
}
}
