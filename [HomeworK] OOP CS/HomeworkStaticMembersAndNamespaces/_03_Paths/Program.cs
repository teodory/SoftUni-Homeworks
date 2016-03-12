using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Paths
{
    class Program
    {
        static void Main(string[] args)
        {

            Point3D p1 = new Point3D(1, 10, 5);
            Point3D p2 = new Point3D(5, 10, 20);
            Point3D p3 = new Point3D(20, 45, 80);

            List<Point3D> points1 = new List<Point3D> { p1, p2, p3 };
            List<Point3D> points2 = new List<Point3D> { p1, p3 };

            Path3D path1 = new Path3D(points1);
            Path3D path2 = new Path3D(points2);

            Storage.SavePaths(path1, path2);

            Path3D newPath = Storage.LoadPaths();

            Console.WriteLine(newPath);

        }
    }
}
