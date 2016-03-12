using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Problem5
{
    static void Main()
    {
        double reverced = GetRevercedNumber(double.Parse(Console.ReadLine()));
        Console.WriteLine(reverced);
    }

    static double GetRevercedNumber(double number)
    {
        string numberString = Convert.ToString(number);
        List<char> revercedString = new List<char>();

        for (int i = numberString.Length - 1; i >= 0; i--)
        {
            revercedString.Add(numberString[i]);
        }

        numberString = string.Join("", revercedString);
        return double.Parse(numberString);
    }


}

