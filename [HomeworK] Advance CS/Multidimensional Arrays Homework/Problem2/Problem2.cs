using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Problem2
{
    static void Main()
    {

        string param = Console.ReadLine();

        int n = int.Parse(param.Split(' ')[0]);
        int m = int.Parse(param.Split(' ')[1]);

        int[,] matrix = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(input[j]);
            }           
        }

        int maxVal = int.MinValue;
        int xCoor = 0;
        int yCoor = 0;


        for (int i = 0; i < n - 2; i++)
        {
            for (int j = 0; j < m - 2; j++)
            {
                //int current = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                //    + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                //    + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                int current = 0;
                for (int x = i; x < i + 3; x++)
                {
                    for (int y = j; y < j + 3; y++)
                    {
                        current += matrix[x, y];
                    }
                }

                if (current > maxVal)
                {
                    maxVal = current;
                    xCoor = i;
                    yCoor = j; 
                }
            }
        }

        Console.WriteLine("Sum = " + maxVal);

        for (int i = xCoor; i < xCoor + 3; i++)
        {
            for (int j = yCoor; j < yCoor + 3; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }




        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < m; j++)
        //    {
        //        Console.Write(matrix[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}



    }
}

