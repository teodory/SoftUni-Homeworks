using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GenericList
{
    class MainProgram
    {
        static void Main(string[] args)
        {

            var list = new GenericList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);
            list.Add(11);
            list.Add(12);
            list.Add(13);
            list.Add(14);
            list.Add(15);
            list.Add(16);
            list.Add(17);

            list.Remove(0);
            Console.WriteLine(list[12]);
            Console.WriteLine(list[13]);
            Console.WriteLine(list[14]);
            Console.WriteLine(list[15]);

            list.Insert(5, 0);

            Console.WriteLine(list);
        }
    }
}
