using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_BankOfKurtovoKonare;

namespace _02_BankOfKurtovoKonare.Accounts
{
    public abstract class Account : IAccount
    {
        private Customer costumer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        internal Customer Customer { get; set; }

        public decimal Balance { get; set; }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The Interest Rate cannot be negative");
                }
                this.interestRate = value;
            }
        }

        public abstract decimal CalculateInterest(int months, decimal money);
       
        public void Deposit(decimal money)
        {
             this.Balance += money;
        }

    }
}
