using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Problem6
{
    static void Main()
    {
        string input = Console.ReadLine();
        CalculateMinMaxAvrSumAndProduct(input);
    }

    static void CalculateMinMaxAvrSumAndProduct(string numbers)
    {
        int[] numArr = MakeArray(numbers);
        Console.WriteLine("Min: " + GetTheMinFromArray(numArr));
        Console.WriteLine("Max: " + GetMaxFromArray(numArr));
        Console.WriteLine("Sum: " + GetSumFromArray(numArr));
        Console.WriteLine("Average: " + GetAverageFromArray(numArr));
        Console.WriteLine("Product: " + GetProductFromArray(numArr));
    }
    static int[] MakeArray(string numbers)
    {
        int[] array = numbers.Split(' ').Select(int.Parse).ToArray();
        return array;
    }
    static int GetTheMinFromArray(int[] numbers)
    {
        int min = int.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
    }
    static int GetMaxFromArray(int[] numbers)
    {
        int max = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
    static int GetSumFromArray(int[] numbers)
    {
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }


        return sum;
    }
    static double GetAverageFromArray(int[] numbers)
    {
        return GetSumFromArray(numbers) / (double)numbers.Length;
    }
    static int GetProductFromArray(int[] numbers)
    {
        int product = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
}

