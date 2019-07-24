using System;

namespace Shapes.Models
{
    public class Circle
    {
        public double Radius { get; set; }

        public Circle(double lengthRadius)
        {
            Radius = lengthRadius;
        }

        public double GetDiameter()
        {
            double Diameter = 2 * Radius;
            return Diameter;
        }


        public double GetCircumference()
        {
            double Circumference = Math.Round(Math.PI * GetDiameter(), 3);
            return Circumference;
        }
    }
}