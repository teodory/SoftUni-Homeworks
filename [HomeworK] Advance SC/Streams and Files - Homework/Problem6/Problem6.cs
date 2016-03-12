using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;

class Problem5
{
    private static List<string> filesList = new List<string>();
    private static string type;

    static void Main()
    {
        string sourceFile = "../../../Pixar-Geris Game.avi";
        string destinationDirectory = "../";
        int n = 5;
        SplitAndZipFile(sourceFile, destinationDirectory, n);
        UnzipAndAssemblingFiles(destinationDirectory);
    }

    static void SplitAndZipFile(string source, string destination, int parts)
    {
        using (var sourceFile = new FileStream(source, FileMode.Open))
        {
            long partSize = (long)Math.Ceiling((double)sourceFile.Length / parts);

            string partName;
           
            Regex regex = new Regex(@"\.(?<=\.)(\w+)");
            type = Convert.ToString(regex.Match(source));

            long sizeEnd = sourceFile.Length;

            for (int i = 0; i < parts; i++)
            {
                partName = destination + "Part-" + (i + 1);
                filesList.Add(partName);
                using (var partedFile = new FileStream(destination + partName + ".gz", FileMode.Create))
                {
                    Console.WriteLine(partName);

                    using (var  compressionStream = new GZipStream(partedFile, CompressionMode.Compress, false))
                    {
                        byte[] buffer = new byte[partSize];
                        int readBytes = sourceFile.Read(buffer, 0, buffer.Length);
                        compressionStream.Write(buffer, 0, buffer.Length);
                    }
                }
                sizeEnd = sourceFile.Length - (i * partSize);
                if (sizeEnd < partSize)
                {
                    partSize = sizeEnd;
                }
            }
 

        }
    }

    static void UnzipAndAssemblingFiles(string destination)
    {
        using (var destinationFile = new FileStream(destination + "assembling" + type, FileMode.Append))
        {
            foreach (var file in filesList)
            {
                using (var partOfFile = new FileStream(destination + file +".gz", FileMode.Open))
                {
                    byte[] bytes = new byte[partOfFile.Length];
                    int readBytes = partOfFile.Read(bytes, 0, bytes.Length);
                    destinationFile.Write(bytes, 0, readBytes);
                }
            }
        }
    }
}

