using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Function c1 = new Function("Math", "Easy");
            c1.Sum(7, 7);
            c1.ShowInfo();
            Function c2 = new Function("Physics", "Hard");
            c2.Devision(8, 4);
            c1.ShowInfo();

            c1.sc(12, 3);
            c1.ShowInfo();
        }
    }
}
