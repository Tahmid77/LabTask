using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Accounts a1 = new Savings("Tahmid", 501010, 1500);
            Accounts a2 = new SpecialSavings("Sakib", 985114, 1400, 50);

            Accounts a3 = new Fixed("Tahmid", 565478, 8964);

            Overdraft o = new Overdraft("Tahmid", 456987, 4567, 7894);
        }
    }
}
