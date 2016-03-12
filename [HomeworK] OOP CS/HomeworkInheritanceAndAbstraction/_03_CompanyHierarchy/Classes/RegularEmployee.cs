using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CompanyHierarchy
{
    class RegularEmployee : Employee
    {
        public RegularEmployee(string id, string firstName, string lastName, decimal salary, Departament departament)
            :base(id,firstName,lastName, departament, salary)
        {

        }
    }
}
