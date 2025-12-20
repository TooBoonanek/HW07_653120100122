namespace cs_oopwork07;

class Program
{
    static void Main(string[] args)
    {
        var cir1 = new Circle();
        Console.WriteLine(cir1.cirInfo);
        cir1.Radius = 5.0;
        Console.WriteLine(cir1.cirInfo);
        var cir2 = new Circle { Radius = 6.0 };
        Console.WriteLine(cir2.cirInfo);

        var cy1 = new Cylinder();
        Console.WriteLine(cy1.CyInfo);
        cy1.Radius = 3.0;
        cy1.Length = 6.0;
        Console.WriteLine(cy1.CyInfo);
        var cy2 = new Cylinder { Radius = 4.0, Length = 4.0 };
        Console.WriteLine(cy2.CyInfo);

        var rec1 = new Rectangle();
        Console.WriteLine(rec1.RecInfo);
        rec1.Width = 5.0;
        rec1.Height = 6.0;
        Console.WriteLine(rec1.RecInfo);
        var rec2 = new Rectangle { Width = 7.0, Height = 5.0 };
        Console.WriteLine(rec2.RecInfo);
    }
}
