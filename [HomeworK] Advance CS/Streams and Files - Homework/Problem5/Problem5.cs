using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
class Problem5
{
    static List<string> resultNames = new List<string>();
    static string type;

    static void Main()
    {
        string sourceFile = "../../../Pixar-Geris Game.avi";
        string destinationDirectory = "../../";

        int n = int.Parse(Console.ReadLine());

        Slice(sourceFile, destinationDirectory, n);

        Assemble(resultNames, "../../TheFILE" + type);
    }

    static void Slice(string sourceFile, string destinationDirectory, int parts)
    {
        using (var file = new FileStream(sourceFile, FileMode.Open))
        {
            Regex regex = new Regex(@"\.(?<=\.)(\w+)");
            type = Convert.ToString(regex.Match(sourceFile));

            long PartLength = file.Length / parts + 1;
            byte[] part = new byte[file.Length * 2];

            int start = 0;

            int partName = 0;
            while (true)
            {
                int readBytes = file.Read(part, start, (int)PartLength);    // тук ще счупи
                if (readBytes == 0)
                {
                    break;
                }

                string resultFileName = destinationDirectory + "Part-" + ++partName + type;
                resultNames.Add(resultFileName);
                using (var filePart = new FileStream(resultFileName, FileMode.Create))
                {
                    filePart.Write(part, start, readBytes);
                }
                start += (int)PartLength;                                   // тук ще счупи
            }
        }
    }
    static void Assemble(List<string> files, string destinationDirectory)
    {
        using (var allFilesInOne = new FileStream(destinationDirectory, FileMode.Append))
        {
            foreach (var destination in resultNames)
            {
                using (var filePart = new FileStream(destination, FileMode.Open))
                {
                    byte[] bytes = new byte[filePart.Length];
                    int readBytes = filePart.Read(bytes, 0, bytes.Length);
                    allFilesInOne.Write(bytes, 0, readBytes);
                }
            }
        }



    }
}