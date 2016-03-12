using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Problem3
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();  //{ 1, 3, 4, 5, 1, 0, 5 };
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i] + "  " + IsLargerThanNeighbous(numbers, i));
        }
    }

    static bool IsLargerThanNeighbous(int[] number, int i)
    {
        if (i == 0 && number[i] > number[i + 1])
        {
            return true;
        }
        else if (i == number.Length - 1 && number[i] > number[i - 1])
        {
            return true;
        }
        else if (number[i] > number[i + 1] && number[i] > number[i - 1])
        {
            return true;
        }

        return false;
    }
}

