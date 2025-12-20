namespace cs_oopwork07;
    public class Cylinder
    {

        public double Radius { get; set; } = 1.0;
        public double Length { get; set; } = 1.0;


        public double area => return 2 * Math.PI * Radius * (Radius + Length);

        public double volume => return area() * Length;

        public void CyInfo => $"Cylinder: Radius = {Radius:N2}, Length = {Length:N2}, Area = {area:N2}, Volume = {volume:N2}";
    }
