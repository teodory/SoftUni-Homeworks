using HomeworkDefiningClasses.Problem2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Person p1 = new Person("Pesho", 20);
            //Person p2 = new Person("Gosho", 19, "abv@vba.bg");
            //Person p3 = new Person("Panayot", 99, "sdads");
            //Person p4 = new Person("", 22, "dsada@s");
            //Person p5 = new Person("dasda", 101, "wsa@das");


            //Console.WriteLine(p1.ToString());
            //Console.WriteLine(p2.ToString());
            //Console.WriteLine(p3.ToString());
            //Console.WriteLine(p4);
            //Console.WriteLine(p5);



            Laprop l1 = new Laprop("acer", 100);
            Laprop l2 = new Laprop("asus", 1001);
            Laprop l3 = new Laprop("Lenovo Yoga 2 Pro", "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                            8, "Intel HD Graphics 4400", "128GB SSD", "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display",
                            "Li-Ion, 4-cells, 2550 mAh", 4.5, 2259.00);

            Console.WriteLine(l1.ToString());
            Console.WriteLine();
            Console.WriteLine(l2.ToString());
            Console.WriteLine();
            Console.WriteLine(l3.ToString());


        }
    }
}
