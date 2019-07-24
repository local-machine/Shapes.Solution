using System;

namespace Shapes.Models
{
    public class Circle
    {
        public int Radius { get; set; }

        public Circle(int lengthRadius)
        {
          Radius = lengthRadius;
        }

        public int GetDiameter()
        {
          int Diameter = 2 * Radius;
          return Diameter;
        }

        // public int 
    }
}