using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapAB
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 7;
            Console.WriteLine($"b = {b} a = {a}");
            b = b * a;
            a = b / a;
            b = b / a;
            Console.WriteLine($"b = {b} a = {a}");
            Console.WriteLine();

            int g = 69;
            int m = 70;
            Console.WriteLine($"m = {m} g = {g}");
            m = m * g;
            g = m / g;
            m = m / g;
            Console.WriteLine($"m = {m} g = {g}");

            SwapVar();


            int n = 568;
            int acc = 0;

            while (n > 0)
            {
                acc += n % 10;
                n = n / 10;
            }
            Console.WriteLine( acc); 

        }

        private static void SwapVar()
        {
            Console.WriteLine("input two variables");
            string stra = Convert.ToString(Console.ReadLine());
            string strb = Convert.ToString(Console.ReadLine());
            int a = int.Parse(stra);
            int b = int.Parse(strb);
            Console.WriteLine($"a = {a} b = {b}");
            b = b * a;
            a = b / a;
            b = b / a;
            Console.WriteLine($"a = {a} b = {b} ");
            Console.WriteLine();
            SwapVar();
        }
    }
}


