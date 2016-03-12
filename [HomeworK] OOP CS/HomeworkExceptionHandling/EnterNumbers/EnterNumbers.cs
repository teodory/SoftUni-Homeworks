using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandaling
{

    class EnterNumbers
    {
        static void Main(string[] args)
        {
            ReadNumber(1, 100);

        }

        static void ReadNumber(int start, int end)
        {
            for (int i = 0; i < 10; i++)
            {
                try
                {

                    int number = int.Parse(Console.ReadLine());
                    if (start > number || number > end)
                    {
                        throw new IndexOutOfRangeException();
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Format Exception");
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Index Out Of Range Exception");
                }
            }
        }
    }
}

