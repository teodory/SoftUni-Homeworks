using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Problem1
{
    static void Main()
    {
        //FirstName, LastName, Age, FacultyNumber, Phone, Email, Marks (IList<int>), GroupNumber

        var studentsList = new List<Student>{ 
            new Student ("Ivan", "Ivanov", 23, "111115", 
                "02900909", "ivan@abv.bg", new List<int>{2, 3, 4, 6, 5}, 1)};

        studentsList.Add(new Student("Stoyan", "Georgiev", 25, "112114", 
            "+35920888", "100yan@gmail.com", new List<int> { 4, 5, 4, 3, 6 }, 1));

        studentsList.Add(new Student("Dragan", "Popov", 24, "111214",
            "0887", "drago@gmail.com", new List<int> { 4, 4}, 2));

        studentsList.Add(new Student("Svetla", "Simeonova", 22, "112215",
         "+359 2 0886", "sTymna@gmail.com", new List<int> { 5, 5, 4, 4, 5 }, 2));



        //   Problem 2.	Students by Group
        Console.WriteLine("Problem 2. Students by Group");
        var groupTwo = 
            from student in studentsList
            orderby student.FirstName
            where student.GroupNumber == 2
            select student;

        foreach (var student in groupTwo)
        {
            Console.WriteLine("{0} {1}  Group Number : {2}", 
                student.FirstName, student.LastName, student.GroupNumber);
        }
        Console.WriteLine();


        //Problem 3. Students by First and Last Name
        Console.WriteLine("Problem 3. Students by First and Last Name");
        var sortedByName =
            from student in studentsList
            orderby student.FirstName
            where student.FirstName.CompareTo(student.LastName) == -1
            select student;

        foreach (var student in sortedByName)
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
        }
        Console.WriteLine();


        //Problem 4. Students by Age
        Console.WriteLine("Problem 4. Students by Age");

        var studentAge =
            from student in studentsList
            where student.Age <= 24 && student.Age >= 18
            select student;

        foreach (var student in studentAge)
        {
            Console.WriteLine("{0} {1} Age:{2}"
                ,student.FirstName, student.LastName, student.Age);
        }
        Console.WriteLine();
        

        //Problem 5. Sort Students
        Console.WriteLine("Problem 5. Sort Students");

        var sortStudents = studentsList
             .OrderBy(s => s.FirstName)
             .ThenBy(s => s.LastName)
             .Select(s => s);

        foreach (var student in sortStudents)
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
        }

        //var std =                     //LINQ syntax
        //    from stud in studentsList
        //    orderby stud.LastName
        //    orderby stud.FirstName
        //    select stud;

        //foreach (var item in std)
        //{
        //    Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
        //}
        Console.WriteLine();

        //Problem 6. Filter Students by Email Domain
        Console.WriteLine("Problem 6. Filter Students by Email Domain");
        var studentEmail = studentsList.Where(st => st.Email.Contains("@abv.bg")).Select(st => st);

        foreach (var student in studentEmail)
        {
            Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Email);
        }
        Console.WriteLine();


        //Problem 7. Filter Students by Phone
        Console.WriteLine("Problem 7. Filter Students by Phone");
        var studentPhones =
            from std in studentsList
            where std.Phone.StartsWith("02")
            || std.Phone.StartsWith("+3592")
            || std.Phone.StartsWith("+359 2")
            select std;
        foreach (var student in studentPhones)
        {
            Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Phone);
        }
        Console.WriteLine();


        //Problem 8.	Excellent Students
        Console.WriteLine("Problem 8. Excellent Students");
        var studentMarks =
            from st in studentsList
            where st.Marks.Contains(6)
            select st;

        foreach (var item in studentMarks)
        {
            Console.WriteLine("{0} {1} Marks: {2}", item.FirstName, item.LastName, 
                string.Join(", ", item.Marks));
        }
        Console.WriteLine();


        //Problem 9.	Weak Students
        Console.WriteLine("Problem 9. Weak Students");
        var studentsTwoMarks =
            from st in studentsList
            where st.Marks.Count == 2
            select st;

        foreach (var item in studentsTwoMarks)
        {
            Console.WriteLine("{0} {1} Marks: {2}", item.FirstName, item.LastName,
                string.Join(", ", item.Marks));
        }
        Console.WriteLine();


        //Problem 10. Students Enrolled in 2014
        Console.WriteLine("Problem 10. Students Enrolled in 2014");
        var studentEnrolled =
            from st in studentsList
            where st.FacultyNumber[4].Equals('1')
            && st.FacultyNumber[5].Equals('4')
            select st;

        foreach (var item in studentEnrolled)
        {
            Console.WriteLine("{0} {1} Marks: {2}", item.FirstName, item.LastName,
                string.Join(", ", item.Marks));
        }
    }
}
