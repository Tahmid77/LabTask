using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{
    class Savings : Accounts
    {


        public Savings(string name, int? accNo, double balance) : base(name, accNo, balance)
        {
            maximumTransaction = 100;
        }

        public override void Withdraw(double amount)
        {
            if (Balance - amount >= 500 && TransactionNum <= maximumTransaction)
            {
                Balance -= amount;
                TransactionNum++;
            }
            else
            {
                Console.WriteLine("You can not withdraw. Amount reached least balance");
            }
        }
    }
}
