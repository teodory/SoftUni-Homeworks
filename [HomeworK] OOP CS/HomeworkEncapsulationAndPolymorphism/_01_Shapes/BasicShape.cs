using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes
{
    public abstract class BasicShape : IShape
    {

        private double width;
        private double height;

        protected BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        protected double Width
        {
            get;
            set;
        }
        protected double Height
        {
            get;
            set;
        }

        public abstract double CalculateArea();
       
        public abstract double CalculatePerimeter();
       
    }
}
