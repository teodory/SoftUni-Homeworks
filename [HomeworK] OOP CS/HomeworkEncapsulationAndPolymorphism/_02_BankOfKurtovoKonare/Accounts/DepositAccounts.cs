using _02_BankOfKurtovoKonare.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankOfKurtovoKonare
{
    class DepositAccounts : Account
    {

        public DepositAccounts(Customer costumer, decimal balance, decimal interestRate)
            :base(costumer, balance, interestRate)
        {
        }

        public void Withdraw(decimal money){
            this.Balance = this.Balance - money;
        }

        public override decimal CalculateInterest(int months, decimal money)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            return money * (1 + this.InterestRate * months);
        }
    }
}
