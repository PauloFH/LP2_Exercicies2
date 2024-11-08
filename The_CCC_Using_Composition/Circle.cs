namespace The_CCC_Using_Composition;

public class Circle {
    private double _radius = 1.0;
    private string _color = "red";

    public Circle() {
    }
    
    public Circle(double radius, string color) {
        Radius = radius;
        Color = color;
    }
    
    public Circle(double radius) {
        Radius = radius;
    }

    public double Radius {
        get => _radius;
        set => _radius = value;
    }

    public string Color {
        get => _color;
        set => _color = value;
    }

    public double Area =>Math.PI * Radius * Radius;
    public override string ToString() {
        return $"Circle[Radius={Radius:F2},Color={Color}]";
    }
}
