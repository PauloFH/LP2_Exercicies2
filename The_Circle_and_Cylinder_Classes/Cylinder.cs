namespace The_Circle_and_Cylinder_Classes;

public class Cylinder : Circle {
    private double _height = 1.0;

    public double Height {
        get => _height;
        set => _height = value;
    }

    public double Volume => Area * Height;

    public Cylinder() : base() {
    }
    public Cylinder(double radius) : base(radius) {
    }
    public Cylinder(double radius, double height) : base(radius) {
        Height = height;
    }
    public Cylinder(double radius, double height, string color) : base(radius, color) {
        Height = height;
    }
    public override string ToString() {
        return $"Cylinder: subclass of {base.ToString()}, height = {Height}";
    }
}
