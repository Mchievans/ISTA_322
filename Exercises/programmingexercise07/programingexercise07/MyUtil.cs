using System;


namespace programingexercise07
{
    public class MyUtil
    {
        public static int outcome = 0;
        private int[] ColumnOne = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };





        public void EvenOdd(int outcome)
        {
            int remainder = 0;
            int oRemainder = 1;
            int check = outcome % 2;
            if (remainder == check)
            {
                Console.WriteLine("even");
            }
            else if (oRemainder == check)
            {
                Console.WriteLine("odd");
            }
        }

        //Reds or Blacks
        public void RedBlack(string bin)
        {
            if (bin == "black")
                Console.WriteLine("black");
            else if (bin == "green")
                Console.WriteLine("green");
            else
                Console.WriteLine("red");
        }

        //Lows or Highs
        public void LowHigh(int outcome)
        {
            if (outcome <= 18)
                Console.WriteLine("Lows");
            else
                Console.WriteLine("Highs");
        }

        //Dozens(Thirds)
        public void GetThirds(int outcome)
        {
            if (outcome >= 1 && 12 >= outcome)
                Console.WriteLine("1-12");
            else if (outcome >= 13 && 24 >= outcome)
                Console.WriteLine("13-24");
            else if (outcome >= 25 && 36 >= outcome)
                Console.WriteLine("25-36");
        }

        //Print An Array
        static void PrintArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]},");
            }
        }

        //GET Columns
        public void GetColumnThree(int[] bin, int outcome)
        {
            int temp = 0;
            int[] holder = new int[bin.Length];

            if (outcome % 3 == 0)
            {
                for (int j = 0; j < bin.Length; j++)
                {
                    temp = bin[j] - 1;
                    if (temp % 3 == 0)
                    {
                        if (temp != 0)
                        {
                            holder[j] = temp;
                            Console.Write($"{holder[j]},");
                        }
                    }
                }
            }
        }
        //GET Columns
        public void GetColumnOne(int[] bin, int outcome)
        {
            int temp = 0;
            outcome = outcome - 1;
            int[] holder = new int[bin.Length];

            if (outcome % 3 == 0)
            {
                for (int j = 0; j < bin.Length; j++)
                {
                    temp = bin[j] - 1;
                    if (temp % 3 == 0)
                    {
                        if (temp != 0)
                        {
                            holder[j] = temp - 2;
                            Console.Write($"{holder[j]},");
                        }
                    }
                }
            }
        }
        //GET Columns
        public void GetColumnTwo(int[] bin, int outcome)
        {
            int temp = 0;
            //outcome = outcome - 1;
            int[] holder = new int[bin.Length];

            if (outcome % 3 == 2)
            {
                for (int j = 0; j < bin.Length; j++)
                {
                    temp = bin[j] - 1;
                    if (temp % 3 == 0)
                    {
                        if (temp != 0)
                        {
                            holder[j] = temp - 1;
                            Console.Write($"{holder[j]},");                       
                        }
                    }
                }
            }
        }
        ////Get Streets (return this array and use it for streets
        ////then write new methid that takes array and cr
        //public void GetStreets(int[] bin, int outcome)
        //{
        //    int temp = 0;
        //    int[] holder = new int[bin.Length];
        //    if (outcome % 3 == 2)
        //    {
        //        for (int j = 0; j < bin.Length; j++)
        //        {
        //            temp = bin[j] - 1;
        //            if (temp % 3 == 0)
        //            {
        //                if (temp != 0)
        //                {
        //                    holder[j] = temp - 1;
        //                    Console.Write($"{holder[j]},");
        //                }
        //            }
        //        }
        //    }
        //}

        public void GetColumnBlue(int[] bin, int outcome)
        {
            int temp = 0;
            //outcome = outcome - 1;
            int[] holder = new int[bin.Length];

            if (outcome % 3 == 2)
            {
                for (int j = 0; j < bin.Length; j++)
                {
                    temp = bin[j] - 1;
                    if (temp % 3 == 0)
                    {
                        if (temp != 0)
                        {
                            holder[j] = temp - 1;
                            Console.Write($"{holder[j]},{bin[j]}");
                        }
                    }
                }
            }
        }
    }
}











