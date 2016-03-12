using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDefiningClasses
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(String name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(String name, int age, String email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The Name is empty");
                }
                if (value.Length < 1 && value.Length > 100)
                {
                    throw new ArgumentException("The Name length is out of range");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("The age must be in range [1 - 100]");
                }
                this.age = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (!String.IsNullOrEmpty(value) && !value.Contains('@'))
                {
                    throw new ArgumentException("Not acceptable e-mail");
                }
                this.email = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", this.name, this.age, this.email ?? "[unknown email]");
        }


    }
}
