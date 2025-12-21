namespace cs_oopwork07;
    public class Circle
    {
        public double Radius { get; set; } = 1.0;
        
        public double area => Math.PI * Math.Pow(Radius, 2);

        public string cirInfo => $"Circle: Radius = {Radius:N2}, Area = {area:N2}";
    }
