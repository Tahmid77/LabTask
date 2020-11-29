using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_1
{
    class Function : Calculator, BasicCalculator, ScientificCalculator
    {
        public Function()
        {

        }

        public Function(string name, string taskType) : base(name, taskType)
        {

        }
        public void Devision(int x, int y)
        {
            int div = x / y;
            Console.WriteLine("The devision is : " + div);
        }

        public void Multiplication(int x, int y)
        {
            int mul = x * y;
            Console.WriteLine("The Multiplication is : " + mul);
        }

        public void Sub(int x, int y)
        {
            int sub = x - y;
            Console.WriteLine("The Sub is : " + sub);
        }

        public void Sum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("The Sum is : " + sum);
        }

        public void sc(int x, int y)
        {

            double sc = Math.Pow(x, y);
            Console.WriteLine("The X^Y is  : " + sc);
        }
    }
}
