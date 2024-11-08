namespace The_CCC_Using_Composition;

class Program {
    static void Main(string[] args) {
        Cylinder c1 = new Cylinder();
        Console.WriteLine($"Cylinder:" +
                          $" radius={c1.Radius}" +
                          $" height={c1.Height}" +
                          $" base area={c1.Area:F2}" +
                          $" volume={c1.Volume:F2}");
        Console.WriteLine(c1.ToString()+"\n");
        Cylinder c2 = new Cylinder(10.0);
        Console.WriteLine($"Cylinder:" +
                          $" radius={c2.Radius}" +
                          $" height={c2.Height}" +
                          $" base area={c2.Area:F2}" +
                          $" volume={c2.Volume:F2}");
        Console.WriteLine(c2.ToString()+"\n");
        Cylinder c3 = new Cylinder(2.0, 10.0);
        Console.WriteLine($"Cylinder:" +
                          $" radius={c3.Radius}" +
                          $" height={c3.Height}" +
                          $" base area={c3.Area:F2}" +
                          $" volume={c3.Volume:F2}");
        Console.WriteLine(c3.ToString());
    }
}
