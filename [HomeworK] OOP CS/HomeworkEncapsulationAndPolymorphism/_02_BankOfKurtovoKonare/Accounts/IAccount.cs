using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankOfKurtovoKonare
{
    interface IAccount
    {
        decimal CalculateInterest(int months, decimal money);

        void Deposit(decimal money);
        
    }
}
