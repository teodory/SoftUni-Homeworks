using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes
{
    class Rectangle : BasicShape
    {

        public Rectangle(double width, double height)
            :base(width, height)
        {
        }


        public override double CalculateArea()
        {
            return base.Width * base.Height;
        }

        public override double CalculatePerimeter()
        {
            return 2.0 * base.Width + 2.0 * base.Height;
        }
    }
}
