using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.PC_Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Component processor1 = new Component("Intel Proccesor", 10000.00001);
            Component processor2 = new Component("Intel Proccesor", "Intel i7 someDiscription", 50000.00005);

            Component graphics1 = new Component("VideoCard", "Nvidia GeForce GT420M", 1000.0001);
            Component graphics2 = new Component("VideoCard", 4000.0004);

            Component motherboard1 = new Component("Asus", 100.001);
            Component motherboard2 = new Component("Intel", "Intel Chipset bla bli", 300.003);

            Component ram1 = new Component("RAM", "DDR3", 10.01);
            Component ram2 = new Component("RAM", 20.02);

            Component hdd1 = new Component("Hdd", 1.1);
            Component hdd2 = new Component("Hdd", "Samsung SSD", 1.1);

            Computer comp = new Computer("ACER", 0, processor1, graphics1, motherboard1, ram1, hdd1);
            Computer comp1 = new Computer("ASUS", 0, processor2, graphics2, motherboard2, ram2, hdd2);


            comp.DisplayComputerInformation();
            Console.WriteLine();
            comp1.DisplayComputerInformation();

        }
    }
}
