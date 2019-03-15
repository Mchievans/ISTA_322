using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercisepractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int a = r.Next(1, 100);

            Console.WriteLine("I have picked a number, guess what it is ");
            while (true)
            {
                string guess = Console.ReadLine();
                int g = int.Parse(guess);

                if (a > g)
                    Console.WriteLine("your guess was too low, guess again");
                else if (a < g)
                    Console.WriteLine("your guess was too high, guess again");
                else if (a == g)
                    break;
                else
                    Console.WriteLine("ERROR");
            }
        }
    }
}
