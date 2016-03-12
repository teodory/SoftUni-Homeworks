using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_CompanyHierarchy;

namespace _03_CompanyHierarchy
{
    class Manager : Employee
    {
        private HashSet<Employee> employees;
        
        public Manager(string id, string firstName, string LastName, Departament departament, decimal salary, HashSet<Employee> employees = null)
            :base(id, firstName, LastName,  departament, salary)
        {
            this.Employees = employees ?? new HashSet<Employee>();
        }


        public HashSet<Employee> Employees
        {
            get
            {
                return this.employees;
            }
            set
            {
                this.employees = value;
            }
        }

        public void AddEmployee(Employee employee)
        {
            this.employees.Add(employee);
        }

        public override string ToString()
        {

            return string.Format("Position: {0}\r\n{1}\r\nEmployees List: {2}",
                this.GetType().Name, base.ToString(), string.Join(", ", this.employees));
        }

    }
}
