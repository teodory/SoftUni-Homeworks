using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Problem1
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../../text.txt");
        //("D:/Visual studio 2013/Projects/Streams and Files - Homework/text.txt");

        int lineIndex = 0;
        string line = reader.ReadLine();

        while (line != null)
        {
            if (lineIndex % 2 != 0)
            {
                Console.WriteLine(line);
            }
            lineIndex++;
            line = reader.ReadLine();
        }
    }
}

