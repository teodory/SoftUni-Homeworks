using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HumanStudentWorker
{
    class Worker : Human
    {

        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            :base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return (this.WeekSalary / (decimal) 5) / WorkHoursPerDay;
        }

        public override string ToString()
        {
            string res = base.ToString();
            res += String.Format("Money Per Hour: {0}", this.MoneyPerHour());
           return res ;

            //return string.Format("First Name: {0} Last Name: {1} Money Per Hour: {2}",
            //    this.FirstName.PadRight(10), this.LastName.PadRight(10), this.MoneyPerHour());
        }
    }
}
