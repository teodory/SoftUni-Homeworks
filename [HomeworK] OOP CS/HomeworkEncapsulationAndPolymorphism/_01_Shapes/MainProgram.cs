using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(3.5);
            Circle circle2 = new Circle(2.5);

            Rectangle rec1 = new Rectangle(2, 2.3);
            Rectangle rec2 = new Rectangle(2.5, 4);

            Rhombus rhb1 = new Rhombus(2.3, 2);
            Rhombus rhb2 = new Rhombus(2.4, 4.33);

            List<IShape> list = new List<IShape>(){
               circle1, circle2, rec1, rec2, rhb1, rhb2
            };

            list.ForEach(s => Console.WriteLine
                (s.GetType().Name + " Perimeter: " + s.CalculatePerimeter()));

            Console.WriteLine();

            list.ForEach(s => Console.WriteLine(s.GetType().Name + " Area: " + s.CalculateArea()));

        }
    }
}
