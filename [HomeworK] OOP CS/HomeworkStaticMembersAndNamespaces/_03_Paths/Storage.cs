using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Paths
{
    static class Storage
    {
        public static void SavePaths(params Path3D[] paths)
        {
            FileStream fs = null;

            try
            {
                fs = new FileStream("../../PathsFile.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);

                using (sw)
                {
                    foreach (Path3D path in paths)
                    {
                        sw.Write(path);
                    }
                }
                fs.Dispose();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static Path3D LoadPaths()
        {
            List<Point3D> points = new List<Point3D>();

            Path3D path;

            try
            {
                StreamReader sr = new StreamReader("../../PathsFile.txt");
                using (sr)
                {
                    String line = sr.ReadLine();
                    
                    while (line != null)
                    {
                        points.Add(Get3DPoints(line));
                        line = sr.ReadLine();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            path = new Path3D(points);
            return path;
        }

        private static Point3D Get3DPoints(string line)
        {
            int[] coordinates = line.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
            return new Point3D(coordinates[0], coordinates[1], coordinates[2]);
        }

    }
}
