using _02_BankOfKurtovoKonare.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankOfKurtovoKonare
{
    class MortgageAccounts : Account
    {
    
        public MortgageAccounts(Customer costumer, decimal balance, decimal interestRate)
            :base(costumer, balance, interestRate)
        {
        }
        public override decimal CalculateInterest(int months, decimal money)
        {
            //•	Mortgage accounts have ½ interest for the first 12 months for companies 
            //and no interest for the first 6 months for individuals.

            if (months >= 12 && this.Customer == Customer.Company)
            {
                return 0.5m * (money * (1 + this.InterestRate * 12));
            }
            else if (this.Customer == Customer.Individual && months > 6)
            {
                return money * (1 + this.InterestRate * (months - 6));
            }
            return 0;
            
        }
    }
}
