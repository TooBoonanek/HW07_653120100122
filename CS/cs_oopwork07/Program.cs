namespace cs_oopwork07;

class Program
{
    static void Main(string[] args)
    {
        var cir1 = new Circle();
        cir1.cirInfo();
        cir1.Radius = 5.0;
        cir1.cirInfo();

        var cy1 = new Cylinder();
        cy1.CyInfo();
        cy1.Radius = 3.0;
        cy1.Length = 6.0;
        cy1.CyInfo();

        var rec1 = new Rectangle();
        rec1.RecInfo();
        rec1.Width = 5.0;
        rec1.Height = 6.0;
        rec1.RecInfo();
    }
}
