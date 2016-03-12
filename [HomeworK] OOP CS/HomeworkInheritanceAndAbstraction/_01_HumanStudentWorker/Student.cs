using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HumanStudentWorker
{
    class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;

        }

        public string FacultyNumber
        {
            get 
            { 
                return this.facultyNumber;
            }
            set 
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("The Faculty Number shuoud be in range [5 - 10]");
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("First Name: {0} Last Name: {1} Faculty Number: {2}",
                this.FirstName.PadRight(10), this.LastName.PadRight(10), this.FacultyNumber);
        }
    }
}
