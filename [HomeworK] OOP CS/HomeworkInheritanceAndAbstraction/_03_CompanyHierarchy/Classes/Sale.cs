using _03_CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _03_CompanyHierarchy
{
    public class Sale : ISale
    {
        private string name;
        private DateTime date;
        private decimal price;

        public Sale(string name, DateTime date, decimal price)
        {
            this.Name = name;
            this.Date = date;
            this.Price = price;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The Sale name cannot be empty");
                }
                this.name = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }

            set
            {
                this.date = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The Price cannot be negative");
                }
                this.price = value;
            }
        }


        public override string ToString()
        {
            return string.Format("Sale: {0}, Date: {1}, Price: {2}", this.Name, this.Date, this.Price);
        }

       
    }
}
