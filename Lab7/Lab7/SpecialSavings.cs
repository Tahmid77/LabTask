using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{
    class SpecialSavings : Accounts
    {


        public SpecialSavings(string name, int? accNo, double balance, int maximumTransactions) : base(name, accNo, balance)
        {
            this.maximumTransaction = maximumTransaction;
        }
        public override void Withdraw(double amount)
        {
            if (TransactionNum <= maximumTransaction && Balance - amount >= amount * 20 / 100)
            {
                Balance -= amount;
                TransactionNum++;
            }
            else
            {
                Console.WriteLine("Invalid request of amount");
            }
        }
    }
}
