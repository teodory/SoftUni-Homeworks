using _02_BankOfKurtovoKonare.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankOfKurtovoKonare
{
    public class LoanAccounts : Account
    {
        public LoanAccounts(Customer customer, decimal balance, decimal interestRate)
            :base(customer, balance, interestRate)
        {

        }

        public override decimal CalculateInterest(int months, decimal money)
        {
            if (months < 3 && this.Customer == Customer.Individual)
            {
                return 0;
            }
            else if (months < 2 && this.Customer == Customer.Company)
            {
                return 0;
            }
            return money * (1 + this.InterestRate * months);
        }
    }
}
