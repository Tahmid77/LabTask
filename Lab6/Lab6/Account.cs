using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Account
    {
        private string accName;

        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        private string acid;

        public string Acid
        {
            get { return acid; }
            set { acid = value; }
        }
        private int balance;

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Account()
        {

        }
        public Account(string accName,string acid,int balance)
        {

        }
        public void Deposit(int amount)
        {

        }
        public void Withdraw(int amount)
        {

        }

        public void Transfer(int amount,Account receiver)
        {

        }

    }
}
