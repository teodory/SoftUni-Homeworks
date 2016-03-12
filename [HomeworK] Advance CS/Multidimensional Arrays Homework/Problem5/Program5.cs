using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program5
{
    static int coins = 0;
    static int walls = 0;
    static int x = 0;
    static int y = 0;

    static void Main()
    {
        string[][] table = new string[4][];

        for (int i = 0; i < table.GetLength(0); i++)
        {
            string input = Console.ReadLine();
            table[i] = new string[input.Length];

            for (int j = 0; j < input.Length; j++)
            {
                table[i][j] =  input[j].ToString();
            }
        }

        string moves = Console.ReadLine();
        if (table[x][y] == "$")
        {
            coins++;
        }
        for (int i = 0; i < moves.Length; i++)
        {
            char currentMove = moves[i];

            switch (currentMove)
            {
                case '>': MoveRight(table); break;
                case '<': MoveLeft(table); break;
                case '^': MoveUp(table); break;
                case 'V': MoveDown(table); break;
                default: Console.WriteLine("WRONG INPUT");
                    break;
            }
            if (table[x][y] == "$")
            {
                coins++;
            }
        }
        Console.WriteLine("Coins collected: " + coins);
        Console.WriteLine("Walls hit: " + walls);
    }

    static void MoveRight(string[][] table)
    {
        int leftEnd = table[x].Length - 1;
        y++;

        if (y > leftEnd)
        {
            walls++;
            y--;
        }
    }

    static void MoveLeft(string[][] table)
    {
        y--;
        if (y < 0)
        {
            walls++;
            y++;
        }
    }
    static void MoveUp(string[][] table)
    {
        x--;
        if (x < 0 || y > table[x].Length)
        {
            walls++;
            x++;
        }
    }
    static void MoveDown(string[][] table)
    {
        int downEnd = table.GetLength(0) - 1;

        x++;
        if (x > downEnd || y > table[x].Length)
        {
            walls++;
            x--;
        }
    }

}

