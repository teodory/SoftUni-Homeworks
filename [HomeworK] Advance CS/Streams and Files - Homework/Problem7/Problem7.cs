
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;

class Problem7
{
    private static void Main()
    {
        Regex regex = new Regex(@"(?<=\w\.)\w+");

        Dictionary<string, List<string>> itemsList = new Dictionary<string, List<string>>();

        DirectoryInfo d = new DirectoryInfo(@"D:\Windows 7");
        FileInfo[] files = d.GetFiles();

        foreach (FileInfo file in files)
        {
            string keyStr = regex.Match(file.Name).ToString();
            if (!itemsList.ContainsKey(keyStr))
            {
                itemsList.Add(keyStr, new List<string>());
            }

            string size = string.Format("{0:F3}", (double)file.Length / 1024);

            itemsList[keyStr].Add(file.Name + " - " + size + "kb");

            //Console.WriteLine(file.Name);
        }

        string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        using (var writeInfo = new StreamWriter(path + "\\report.txt"))
        {
            foreach (var item in itemsList)
            {
                writeInfo.WriteLine("." + item.Key);

                foreach (var file in itemsList[item.Key])
                {
                    writeInfo.WriteLine("--{0}", file);
                }
            }
        }



    }
}
