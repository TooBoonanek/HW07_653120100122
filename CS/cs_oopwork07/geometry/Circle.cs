namespace cs_oopwork07;
    public class Circle
    {
        private double radius;

        public double Radius { get => radius; set => radius = value; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(): this(1.0){}

        public double area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double diamater()
        {
            return 2 * Radius;
        }

        public double circumference()
        {
            return 2 * Math.PI * Radius;
        }

        public void cirInfo()
        {
            System.Console.WriteLine($"Circle: Radius = {Radius:N2}, Area = {area():N2}, Diameter = {diamater():N2}, Circumference = {circumference():N2}");
        }
    }