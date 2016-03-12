using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Problem2
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("../../../text.txt"))
        {
            using (StreamWriter writer = new StreamWriter("../../../newText.txt"))
            {
                int lineNumber = 0;
                string line = reader.ReadLine();

                while (line != null)
                {
                    lineNumber++;
                    writer.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();
                }
            }
        }
    }
}

