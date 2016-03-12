using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_InterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal, int, decimal> func = GetSimpleInterest;

            decimal simle = func(2500m, 7.2m, 15);
            Console.WriteLine("{0:F4}", simle);

            func = GetCompoundInterest;
            var compound = func(500m, 5.6m, 10);
            Console.WriteLine("{0:F4}", compound);
        }


        public static decimal GetSimpleInterest(decimal money, decimal interest, int years)
        {
            return money * (1 + (interest / 100) * years);
        }

        public static decimal GetCompoundInterest(decimal sum, decimal interest, int years)
        {
            //A = sum * (1 + interest / n)year * n
            return sum * (decimal)Math.Pow( (1 + ( ( (double)interest / 100 ) / 12) ), years * 12);
        }
    }
}
