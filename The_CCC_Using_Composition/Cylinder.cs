namespace The_CCC_Using_Composition;

public class Cylinder{
    private Circle _base;
    private double _height = 1.0;

    public double Height {
        get => _height;
        set => _height = value;
    }

    public double Radius {
        get => _base.Radius;
        set => _base.Radius = value;
    }
    public string Color {
        get => _base.Color;
        set => _base.Color = value;
    }
    public double Area => _base.Area;
    public double Volume => _base.Area * Height;

    public Cylinder(){
        _base = new Circle();
    }
    public Cylinder(double radius){
        _base = new Circle(radius);
    }
    public Cylinder(double radius, double height){
        _base = new Circle(radius);
        Height = height;
    }
    public Cylinder(double radius, double height, string color){
        Height = height;
        _base = new Circle(radius, color);
    }
    public override string ToString() {
        return $"Cylinder: base=(radius={Radius}, color={Color}), height = {Height}";
    }
}
