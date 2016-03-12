using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Problem3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        string[,] matrix = new string[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                string input = Console.ReadLine();
                matrix[i, j] = input;
            }
        }

        string command = Console.ReadLine();

        while (command != "END")
        {
            string[] coordinats = command.Split(' ');
            if (command.Contains("swap"))
            {
                int x1 = int.Parse(coordinats[1]);
                int y1 = int.Parse(coordinats[2]);
                int x2 = int.Parse(coordinats[3]);
                int y2 = int.Parse(coordinats[4]);

                if (x1 <= n && x1 >= 0 && y1 <= n && y1 >= 0 && x2 <= m && x2 >= 0 && y2 <= m && y2 >= 0)
                {
                    string swap = matrix[x1, y1];
                    matrix[x1, y1] = matrix[x2, y2];
                    matrix[x2, y2] = swap;
                    PritnMatrix(matrix);
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

            command = Console.ReadLine();
        }
    }

    static void PritnMatrix(string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

