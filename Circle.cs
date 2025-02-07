using System;

namespace SOLID
{
    public class Circle : IShape
    {
        public double Radius { get; set; }
        
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}