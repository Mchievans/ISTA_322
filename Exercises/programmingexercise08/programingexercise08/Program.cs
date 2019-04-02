using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] oneTen = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Welcome to guess my number!, The hit game where the " +
                "computer guesses your number!");
            Console.WriteLine("First step The Framework :Input A number one through 10");
            MyUtil a = new MyUtil();
            string strinput = Convert.ToString(Console.ReadLine());
            int userInput = Convert.ToInt32(strinput);

            try
            {
                //Generates the middle value of the index
                int compareValue = a.GetArrayIndexHalf(oneTen, userInput);

                //Creates path if number lower than middle value of index
                if (userInput < compareValue && userInput < 10)
                {
                    Console.WriteLine($"the value was less than {compareValue}");
                    int[] lowArray = a.GetLow2(ref oneTen, compareValue);
                    Console.WriteLine();
                    int compareValue2 = a.GetArrayIndexHalf(lowArray, userInput);

                    //compareValue2 is now middle value of array
                    if (userInput < compareValue2)
                    {
                        Console.WriteLine($"the value is less than {compareValue2}");
                        int[] lowArray2 = a.GetLow2(ref lowArray, compareValue2);
                        Console.WriteLine();
                        int compareValue3 = a.GetArrayIndexHalf(lowArray2, userInput);

                        if (userInput == compareValue3)
                        {
                            Console.WriteLine("your value is " + compareValue3);
                        }
                        else
                        {
                            Console.WriteLine("your value is " + compareValue3);
                            Console.WriteLine("if not then");
                            compareValue3 += 1;
                            Console.WriteLine(compareValue3);
                        }
                    }
                    else if (userInput > compareValue2)
                    {
                        Console.WriteLine("your value was more than " + compareValue2);
                        //int[] LowArray2 = a.GetLow2(ref lowArray, compareValue);
                        //int[] HighArray = a.GetHigh(ref oneTen, compareValue);
                        //int compareValue3 = a.GetArrayIndexHalf(LowArray2, userInput);
                        // compareValue3 *= 2;
                        //Console.WriteLine(compareValue3);
                        if (userInput != compareValue2)
                        {
                            //Console.WriteLine("your value is " + compareValue2);
                            // Console.WriteLine("if not then");
                            compareValue2 += 1;
                            Console.WriteLine(compareValue2);
                        }
                    }
                    else if (userInput == compareValue2)
                        Console.WriteLine($"your value is {userInput}");
                }
                //Creates path if number higher than middle value of index
                else if (userInput > compareValue && userInput < 11)
                {
                    Console.WriteLine($"the value was more than {compareValue}");
                    int[] HighArray = a.GetHigh(ref oneTen, compareValue);
                    Console.WriteLine();

                    int compareValue2 = a.GetArrayIndexHalf(HighArray, userInput);
                    compareValue2 += 1;
                    compareValue2 *= 2;
                    if (userInput > compareValue2)
                    {
                        Console.WriteLine("your value was greater than " + compareValue2);
                        int[] HighArray2 = a.GetHigh(ref oneTen, compareValue2);
                        Console.WriteLine();
                        if (userInput == 9)
                            Console.WriteLine("your value is " + 9);
                        else
                        {
                            Console.WriteLine("your value is " + 9);
                            Console.WriteLine("if not then " + 10);
                        }
                    }
                    //Creates path if number lower than middle value of index
                    else if (userInput < compareValue2)
                    {
                        Console.WriteLine("your value was less than " + compareValue2);
                        int[] LowArray2 = a.GetLow(HighArray);
                        int compareValue3 = a.GetArrayIndexHalf(LowArray2, userInput);
                        compareValue3 *= 3;
                        Console.WriteLine();
                        if (userInput == compareValue3)
                        {
                            Console.WriteLine("your value is " + compareValue3);
                        }
                        else
                        {
                            Console.WriteLine("your value is " + compareValue3);
                            Console.WriteLine("if not then");
                            compareValue3 += 1;
                            Console.WriteLine(compareValue3);
                        }
                    }
                    // If value is same as middle elment in index
                    else if (userInput == compareValue2 && userInput < 11)
                    {
                        Console.WriteLine("your value is" + compareValue2);
                    }
                }
                // If value is same as middle elment in index
                else if (userInput == compareValue && userInput < 11)
                    Console.WriteLine($"your value is {userInput}");
            }
            catch (Exception IndexOutOfRangeException)
            {
                Console.WriteLine(IndexOutOfRangeException.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Guess the computers number");
            //int[] oneThousand = GetCpuArray();

            int[] oneThousand = new int[1000];
            for (var i = 0; i < oneThousand.Length; i += 1)

                oneThousand[i] = i;
            Random rand = new Random();
            int cpuPick = rand.Next(oneThousand.Length);
            MyUtil b = new MyUtil();
            //Console.WriteLine(cpuPick);
            Console.WriteLine("Use the bisectional algorthim to guess the computers number between 1 and 1000");
            Console.WriteLine();
            Console.WriteLine("input your first guess");
            string strGuess1 = Convert.ToString(Console.ReadLine());
            int userGuess1 = Convert.ToInt32(strGuess1);
            if (userGuess1 == cpuPick)
            {
                Console.WriteLine("you guessed the correct number");
            }
            else if (userGuess1 > cpuPick && userGuess1 < 1000)
            {
                Console.WriteLine("your guess was too high");
                int arraysize = b.GetArrayIndexHalf(oneThousand, userGuess1);
                int [] arrayfirst = b.GetHigh(ref oneThousand,arraysize); 
                
            }
            else if (userGuess1 < cpuPick && userGuess1 < 1000)
            {
                Console.WriteLine("your guess was too low");
                int arraysize = b.GetArrayIndexHalf(oneThousand, userGuess1);

                Console.WriteLine(arraysize);
            }
        }
    }
}
    

