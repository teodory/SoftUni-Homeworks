using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DistanceCalculator
{
    static class DistanceCalculator
    {
        public static double CalculateTheDistance(Point3D one, Point3D two)
        {
          
            //d = \sqrt {(4 - 1)^2 + (5 - 2)^2 + (6 - 3)^2}
            return Math.Sqrt
                (
                Math.Pow((two.X - one.X), 2) + 
                Math.Pow((two.Y - one.Y), 2) + 
                Math.Pow((two.Z - one.Z), 2)
                ); 
        }
    }
}
