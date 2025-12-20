namespace cs_oopwork07;
    public class Rectangle
    {

        public double Width { get; set; } = 1.0;
        public double Height { get; set; } = 1.0;

        public double area => Width * Height;

        public void RecInfo => $"Rectangle: Width = {Width:N2}, Height = {Height:N2}, Area = {area():N2}";
    }
