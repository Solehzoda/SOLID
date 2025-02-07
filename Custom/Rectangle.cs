namespace SOLID
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Length { get; set; }
        
        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }

        public double CalculateArea()
        {
            return Width * Length;
        }
    }
}