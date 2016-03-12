using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HumanStudentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
//•	Initialize a list of 10 students and sort them by faculty number in ascending order 
//(use a LINQ query or the OrderBy() extension method). 
//Initialize a list of 10 workers and sort them by payment per hour in descending order.
//•	Merge the lists and then sort them by first name and last name.

            List<Student> students = new List<Student>()
            {
                new Student("Angel", "Angelov", "123456"),
                new Student("Zlatan", "Bobov", "0099999"),
                new Student("Zlatan", "Anev", "0001001010"),
                new Student("Angel", "Zlatev", "6854841321"),
                new Student("Kiril", "Panchev", "58254")
            };

            students = students.OrderBy(s => s.FacultyNumber).ToList();
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();


            List<Worker> workers = new List<Worker>()
            {
                new Worker("Blagoy", "Zaykov", 1000, 8),
                new Worker("Blagoy", "Alev", 4938, 8),
                new Worker("Peter", "Anev", 100, 8),
                new Worker("Aaaa", "Baaa", 100, 4),
                new Worker("Kiril", "Ganev", 50, 4)
            };

            workers = workers
                .OrderByDescending(w => w.FirstName)
                .ThenBy(w => w.MoneyPerHour())
                .ToList();

            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine();


            var humanList = new List<Human>();
            humanList.AddRange(students);
            humanList.AddRange(workers);

            humanList = humanList.OrderBy(h => h.FirstName)
                .ThenBy(h => h.FirstName)
                .ToList();

            foreach(Human human in humanList){
                Console.WriteLine(human);
            }
        }
    }
}
