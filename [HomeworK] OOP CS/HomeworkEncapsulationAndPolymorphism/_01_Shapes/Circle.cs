using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes
{
    class Circle : IShape
    {
        const double pi = Math.PI;
        private double radius;

        public Circle(double r)
        {
            this.Radius = r;
        }

        public double Radius
        {
            get;
            set;
        }


        public double CalculateArea()
        {
            return pi * this.Radius * this.Radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * pi * this.Radius;
        }
    }
}
