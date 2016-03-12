using _03_CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CompanyHierarchy
{
    class Employee : Person, IEmployee
    {
        //salary and department

        private decimal salary;
        private Departament departament;

        public Employee(string id, string firstName, string lastName, Departament departament, decimal salary)
            :base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Departament = departament;
        }

        private Departament Departament
        {
            get;
            set;
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative");
                }
                this.salary = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, Depatament: {1}, Salary: {2}", base.ToString(), this.Departament, this.Salary);
        }
    }
}
