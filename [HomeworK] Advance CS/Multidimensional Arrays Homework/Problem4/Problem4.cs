using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem4
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
                    matrix[i, j] = Console.ReadLine();
                }
            }

            //string[,] matrix = { { "ha", "fifi", "ho", "hi"},
            //                       {"fo", "ha", "hi", "xx" },
            //                       {"hi", "xo", "ha", "xx"}
            //                   };

            //string[,] matrix ={ {"s", "qq", "s"},
            //                    {"pp", "pp", "s"},
            //                    {"pp", "qq", "s"}
            //                };


            int longest = 0;
            int coorX = 0;
            int coorY = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int current = GetTheLongestSenquence(matrix, i, j);
                    if (current > longest)
                    {
                        longest = current;
                        coorX = i;
                        coorY = j;
                    }
                }
            }

            List<string> list = new List<string>();
            for (int i = 0; i < longest; i++)
            {
                list.Add(matrix[coorX, coorY]);
            }

            Console.WriteLine(string.Join(", ", list));
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        static int GetTheLongestSenquence(string[,] neo, int x, int y)
        {
            int n = neo.GetLength(0);
            int m = neo.GetLength(1);

            string toCHeck = neo[x, y];

            int longest = 0;


            //HORIZONTAL
            int count = 1;
            int indX = y + 1;

            while ( indX < m && toCHeck == neo[x, indX] )
            {
                count++;
                indX++;
            }
            if (count > longest)
            {
                longest = count;
            }
           
            //VERTICAL
            indX = x + 1;
            count = 1;
            while (indX < n && toCHeck == neo[indX, y] )
            {
                count++;
                indX++;
            }
            if (count > longest)
            {
                longest = count;
            }

            //RIGHT DIAGONAL
            indX = x + 1;
            int indY = y + 1;
            count = 1;
            while (indX < n && indY < m && toCHeck == neo[indX, indY])
            {
                count++;
                indX++;
                indY++;
            }
            if (count > longest)
            {
                longest = count;
            }

            //LEFT DIAGONAL
            indX = x + 1;
            indY = y - 1;
            count = 1;
            while (indX < n && indY >= 0 && toCHeck == neo[indX, indY])
            {
                count++;
                indX++;
                indY--;
            }
            if (count > longest)
            {
                longest = count;
            }

            return longest;

        }


    }

