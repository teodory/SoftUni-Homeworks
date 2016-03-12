using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Problem2
{
    static void Main()
    {

        string inputNumber = Console.ReadLine();

        Console.WriteLine(GetLastDigitAsWord(inputNumber));

    }

    static string GetLastDigitAsWord(string number)
    {
        string result;

        switch (number[number.Length - 1])
        {
            case '0': result = "Zero"; break;
            case '1': result = "One"; break;
            case '2': result = "Two"; break;
            case '3': result = "Three"; break;
            case '4': result = "four"; break;
            case '5': result = "Five"; break;
            case '6': result = "Six"; break;
            case '7': result = "Seven"; break;
            case '8': result = "Eight"; break;
            case '9': result = "Nine"; break;
            default: result = "Not a number"; break;
        }
        return result;
    }
}

