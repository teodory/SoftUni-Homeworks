using _03_CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CompanyHierarchy
{
    class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private HashSet<Sale> sales;

        public SalesEmployee(string id, string firstName, string lastName, decimal salary, Departament departament)
            :base(id, firstName, lastName, salary, departament)
        {
            this.sales = new HashSet<Sale>();
        }

        public ISet<Sale> Sales
        {
            get { return this.sales; }
        }

        public void AddSale (Sale sale)
        {
            this.sales.Add(sale);
        }

        public override string ToString()
        {
            return string.Format("Position: {0}\r\n{1}\r\nSales: {2}", this.GetType().Name, base.ToString(), 
                string.Join(", ", this.Sales));
        }
    }
}
