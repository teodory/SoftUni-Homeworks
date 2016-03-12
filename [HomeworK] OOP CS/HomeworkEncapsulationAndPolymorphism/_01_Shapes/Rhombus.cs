using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes
{
    class Rhombus : BasicShape
    {

         public Rhombus(double width, double height)
            :base(width, height)
        {
        }

        public override double CalculateArea()
        {
            return base.Width * base.Height;
        }

        public override double CalculatePerimeter()
        {
            return 4.0 * base.Width;
        }
    }
}
