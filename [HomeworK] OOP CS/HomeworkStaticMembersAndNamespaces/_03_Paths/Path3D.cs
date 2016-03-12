using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Paths
{
    class Path3D
    {
        private List<Point3D> points;

        public Path3D(List<Point3D> list)
        {
            this.points = list;

        }

        public override string ToString()
        {
            string path = "";

            for (int i = 0; i < points.Count; i++)
            {
                path += points[i].X + ", " + points[i].Y + ", " + points[i].Z + "\r\n";
            }


            return path;
        }
    }
}
