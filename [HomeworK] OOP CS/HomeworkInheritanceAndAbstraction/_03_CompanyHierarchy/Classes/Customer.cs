using _03_CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CompanyHierarchy
{
    class Customer : Person, ICostomer
    {
        private decimal netPurchaseAmount;

        public Customer(string id, string firstName, string lastName)
            : base(id, firstName, lastName)
        {
            this.NetPurchaseAmount = 0;
        }

        public decimal NetPurchaseAmount
        {
            get
            {
                return this.netPurchaseAmount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The Purchaset Amount cannot be negative");
                }
                this.netPurchaseAmount = value;
            }
        }


        public void BueProduct(Sale sale)
        {
            this.NetPurchaseAmount += sale.Price;
        }
    }
}
