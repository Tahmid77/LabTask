using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //No 1
            /*
            int n = 100;
            int sum = 0;
            for (int i = 2; i <= n; i = i + 2)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum= " + sum);
            Console.WriteLine();
            */
            //No 2
            /*
            n = 5;
            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("0X0X0X");
                }
                else
                    Console.WriteLine("X0X0X0");
            }
            Console.WriteLine();
            */
            //No 3
            /*
            for (int i = 1; i <= n; i++)
            {
                int j = i + 1, k = i + 2, l = i + 3, m = i + 4;

                Console.WriteLine(i + "" + j + "" + k + "" + l + "" + m + "");
            }
            Console.WriteLine();

            */
            //No 4
            /*
            sum = 0;
            for (int j = 1; j <= 100;)
            {
                sum = sum + j;
                j = j + 2;
            }
            Console.WriteLine("Sum of ODD Number = " + sum);
            sum = 0;
            for (int k = 2; k <= 100;)
            {
                sum = sum + k;
                k = k + 2;
            }
            Console.WriteLine("Sum of Even Number = " + sum);
            Console.WriteLine();
            */
            //No 5
            /*
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(i);
            }
            Console.WriteLine();
            */
            //No 6
            /*
            int fac = 1;
            int q = 5;
            for (int i = 1; i <= q; i++)
            {
                fac = fac * i;

            }
            Console.WriteLine("Factorial is " + fac);
            Console.WriteLine();
            */
            //No 7
            /*
            q = 5;
            for (int i = 1; i <= q; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = q - 1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */
        }
    }
}
