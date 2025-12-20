namespace cs_oopwork07;
    public class Circle
    {
        public double Radius { get; set; } = 1.0;
        
        public double area => Math.PI * Math.Pow(Radius, 2);

        public double diamater => 2 * Radius;

        public double circumference => 2 * Math.PI * Radius;

        public void cirInfo => $"Circle: Radius = {Radius:N2}, Area = {area():N2}, Diameter = {diamater():N2}, Circumference = {circumference():N2}";
    }
