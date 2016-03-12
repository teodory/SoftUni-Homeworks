using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Problem9
{

    static int n = int.Parse(Console.ReadLine());
    static int r = int.Parse(Console.ReadLine());
    static char[,] table = new char[n, n];

    static List<int> coorX = new List<int>();
    static List<int> coorY = new List<int>();

    static void Main()
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                table[i, j] = '.';
            }
        }
        MakeCrossOnTheTable();
        PrintTheTable();
    }
    static void PrintTheTable()
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(table[i, j]);
            }
            Console.WriteLine();
        }

    }

    static void MakeCrossOnTheTable()
    {
        for (int i = n / 2 - r; i < n / 2 + r + 1; i++)
        {
            table[n / 2, i] = '*';
            coorX.Add(i);
        }
        for (int i = n / 2 - r; i < n / 2 + r + 1; i++)
        {
            table[i, n / 2] = '*';
            coorY.Add(i);
        }

        QuadrantTwo();
        QuadrantOne();
        QuadrantTree();
        QuadrantFour();
    }

    static void QuadrantTwo()
    {
        int sizeA = n / 2;
        int sizeB = n / 2;

        for (int i = 0; i < n / 2; i++)
        {
            for (int j = 0; j < n / 2; j++)
            {
                int a = (sizeA - i);
                int b = (sizeB - j);
                if (a * a + b * b  <= r * r)
                {
                    table[i, j] = '*';
                }
            }
        }
    }

    static void QuadrantOne()
    {
        int sizeA = n / 2;
        int sizeB = n / 2;

        for (int i = 0 ; i < n / 2; i++)
        {
            for (int j = n / 2 + 1; j < n; j++)
            {
                int a = (sizeA - i);
                int b = (j - sizeB);
                if (a * a + b * b <= r * r)
                {
                    table[i, j] = '*';
                }
            }
        }
    }

    static void QuadrantTree()
    {
        int sizeA = n / 2;
        int sizeB = n / 2;

        for (int i = n / 2 + 1; i < n; i++)
        {
            for (int j = 0; j < n / 2; j++)
            {
                int a = (i - sizeA);
                int b = (sizeB - j);
                if (a * a + b * b <= r * r)
                {
                    table[i, j] = '*';
                }
            }
        }
    }
    static void QuadrantFour()
    {
        int sizeA = n / 2;
        int sizeB = n / 2;

        for (int i = n / 2 + 1; i < n; i++)
        {
            for (int j = n / 2 + 1; j < n; j++)
            {
                int a = (i - sizeA);
                int b = (j - sizeB);
                if (a * a + b * b <= r * r)
                {
                    table[i, j] = '*';
                }
            }
        }
    }
}

