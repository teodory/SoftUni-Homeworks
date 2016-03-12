using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Problem7
{
    static void Main()
    {
        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
        string[] str = { "zaz", "cba", "baa", "azi" };
        DateTime[] dates = 
        {   new DateTime(2002, 3, 1),
            new DateTime(2015, 5, 6),
            new DateTime(2014, 1, 1) 
        };


        GetSortedArray(numbers);
        Console.WriteLine();
        GetSortedArray(str);
        Console.WriteLine();
        GetSortedArray(dates);

    }

    static void GetSortedArray<T>(T[] value) where T : IComparable
    {
        bool keepIterating = true;

        while (keepIterating)
        {
            keepIterating = false;

            for (int i = 0; i < value.Length - 1; i++)
            {
                T x = value[i];
                T y = value[i + 1];
                if (x.CompareTo(y) > 0)
                {
                    value[i] = y;
                    value[i + 1] = x;
                    keepIterating = true;
                }
            }
        }

        Console.WriteLine(string.Join(", ", value));

    }


}

