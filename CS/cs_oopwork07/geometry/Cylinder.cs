namespace cs_oopwork07;
    public class Cylinder
    {

        public double Radius { get; set; } = 1.0;
        public double Length { get; set; } = 1.0;


        public double area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double volume()
        {
            return Math.PI * Math.Pow(Radius, 2) * Length;
        }

        public void CyInfo()
        {
            System.Console.WriteLine($"Cylinder: Radius = {Radius:N2}, Length = {Length:N2}, Area = {area():N2}, Volume = {volume():N2}");
        }
    }
