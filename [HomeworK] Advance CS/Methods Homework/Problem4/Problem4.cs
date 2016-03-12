using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Problem4
{
    static void Main()
    {
        int[] senquenceOne = { 1, 3, 4, 5, 1, 0, 5 };
        int[] senquenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
        int[] senquenceThree = { 1, 1, 1 };

        Console.WriteLine(GetIndexOfFIrstElementLargerThanTheNeighbours(senquenceOne));
        Console.WriteLine(GetIndexOfFIrstElementLargerThanTheNeighbours(senquenceTwo));
        Console.WriteLine(GetIndexOfFIrstElementLargerThanTheNeighbours(senquenceThree));

    }

    static int GetIndexOfFIrstElementLargerThanTheNeighbours(int[] arr)
    {
        //Check the First element
        if (arr[0] > arr[1])
        {
            return 0; 
        }

        // check all without the last element
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                return i;
            }
        }

        // check the last element
        if (arr[arr.Length - 1] > arr[arr.Length - 2])
        {
            return arr.Length - 1;
        }

        return -1;
    }

}

