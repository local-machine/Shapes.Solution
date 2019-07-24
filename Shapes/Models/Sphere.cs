using System;

namespace Shapes.Models
{
    public class Sphere
    {
      public double Radius { get; set; }

        public Sphere(double lengthRadius)
        {
            Radius = lengthRadius;
        }

        public double GetSurface()
        {
          double Surface = Math.Round(4 * Math.PI * Math.Pow(Radius, 2), 3);
          return Surface;
        }

        public double GetVolume()
        {
          double fourThirds = 4d / 3d;
          double Volume = Math.Round((fourThirds) * Math.PI * Math.Pow(Radius, 3), 3);
          return Volume;
        }
    }
}