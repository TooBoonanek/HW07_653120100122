namespace cs_oopwork07;
    public class Cylinder
    {
        private double radius;
        private double length;

        public double Radius { get => radius; set => radius = value; }
        public double Length { get => length; set => length = value; }

        public Cylinder(double radius, double length)
        {
            this.radius = radius;
            this.length = length;
        }

        public Cylinder():this(1.0, 1.0){}

        public double area()
        {
            return 2 * Math.PI * radius * (radius + length);
        }

        public double volume()
        {
            return area() * length;
        }

        public void CyInfo()
        {
            System.Console.WriteLine($"Cylinder: Radius = {Radius:N2}, Length = {Length:N2}, Area = {area():N2}, Volume = {volume():N2}");
        }
    }
