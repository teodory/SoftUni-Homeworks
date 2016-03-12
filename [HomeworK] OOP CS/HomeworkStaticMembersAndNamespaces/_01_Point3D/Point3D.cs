using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Point3D
{
    class Point3D
    {
        private static readonly Point3D StartPoint = new Point3D (0, 0, 0);
        private int x;
        private int y;
        private int z;

        public Point3D(int x, int y, int z)
        {
            this.x = X;
            this.y = Y;
            this.z = Z;
        }

        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public int Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Starting Point {0} {1} {2}", this.X, this.Y, this.Z);
        }

        public static Point3D GerStartPoint()
        {
            return StartPoint;
        }

    }
}
