using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandaling
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine("{0} square = {1}", number, Math.Sqrt(number));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Negative number" );
                
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Exception" );
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }
        }
    }

}