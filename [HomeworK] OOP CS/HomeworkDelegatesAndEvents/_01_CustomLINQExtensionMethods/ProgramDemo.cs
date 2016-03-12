using System;
using System.Collections.Generic;
using System.Linq;
using _01_CustomLINQExtensionMethods;

namespace _01_CustomLINQExtensionMethods
{
    class ProgramDemo
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine( string.Join(", ", nums.WhereNot(n => n % 2 == 0)));


            var students = new List<Student>()
            {
                new Student("Pesho", 3),
                new Student("Gosho", 2),
                new Student("Mariika", 7),
                new Student("Stamat", 5),
            };

            Console.WriteLine(students.Max(student => student.Grade));
        }


    }
}
