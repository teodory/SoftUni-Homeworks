using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(2, 2, 1);
            Point3D p2 = new Point3D(4, 4, 3);

            Console.WriteLine( DistanceCalculator.CalculateTheDistance(p1, p2));
        }
    }
}
