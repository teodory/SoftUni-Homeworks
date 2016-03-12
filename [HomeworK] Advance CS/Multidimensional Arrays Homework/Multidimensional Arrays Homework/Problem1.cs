using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Problem1
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
      //  int[,] matrix2 = new int[n, n];

        int count = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[j, i] = count;
                count++;
            }
        }

        PrintMatrix(matrix);
        Console.WriteLine();

        count = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i % 2 == 0)
                {
                    matrix[j, i] = count;
                }
                else
                {
                    int reverse = (n - 1) - j;
                    matrix[reverse, i] = count;
                }
                count++;
            }
        }
        PrintMatrix(matrix);

    }

    static void PrintMatrix(int[,] matrix)
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

