namespace cs_oopwork07;
    public class Cylinder
    {
        private double radius;
        private double height;

        public double Radius { get => radius; set => radius = value; }
        public double Height { get => height; set => height = value; }

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public Cylinder():this(1.0, 1.0){}

        public double area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double volume()
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }

        public void CyInfo()
        {
            System.Console.WriteLine($"Cylinder: Radius = {Radius:N2}, Height = {Height:N2}, Area = {area():N2}, Volume = {volume():N2}");
        }
    }