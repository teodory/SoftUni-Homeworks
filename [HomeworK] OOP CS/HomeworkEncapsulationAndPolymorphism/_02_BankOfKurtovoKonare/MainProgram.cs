using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BankOfKurtovoKonare
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            DepositAccounts depo = new DepositAccounts(Customer.Individual, 12112m, 3.4m);
            LoanAccounts loan = new LoanAccounts(Customer.Individual, 12112m, 3.4m);
            MortgageAccounts mortgage = new MortgageAccounts(Customer.Company, 12112m, 3.4m);

            loan.Deposit(100.1m);
            depo.Deposit(100.1m);
            mortgage.Deposit(100.1m);

            Console.WriteLine(loan.Balance);
            Console.WriteLine(depo.Balance);
            Console.WriteLine(mortgage.Balance);
            Console.WriteLine();

            loan.Deposit(10000.9m);
            depo.Withdraw(2212);
            mortgage.Deposit(1010100);

            Console.WriteLine(loan.CalculateInterest(6, 10.10m));
            Console.WriteLine(depo.Balance);
            Console.WriteLine(mortgage.CalculateInterest(13, 10.10m));
            Console.WriteLine();

            
        }
    }
}
