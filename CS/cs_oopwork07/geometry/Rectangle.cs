namespace cs_oopwork07;
    public class Rectangle
    {
        private double width;
        private double height;

        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }

        public Rectangle(): this(1.0, 1.0) {}

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double area()
        {
            return width * Height;
        }

        public void RecInfo()
        {
            System.Console.WriteLine($"Rectangle: Width = {Width:N2}, Height = {Height:N2}, Area = {area():N2}");
        }
    }