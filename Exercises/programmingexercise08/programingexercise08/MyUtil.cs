using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercise08
{
    class MyUtil
    {

        public int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public int[] GetLow(int[] arr1)
        {
            int temp = 0;
            int[] arr2 = new int[arr1.Length - 1];
            for (int i = 0; i < arr1.Length / 2; i++)
            {
                temp = arr1[i];
                arr1[i] = arr2[i];
                arr2[i] = temp;
                Console.Write($"{arr2[i]},");
            }
            return arr2;
        }

        public int[] GetLowPrep(int[] arr1)
        {
            int temp2 = 0;
            int[] arr2 = new int[arr1.Length];
            if (arr1.Length % 2 == 1)
            {
                int temp = (arr1.Length + 1) / 2;
                temp += 1;
                for (int i = 0; i < arr1.Length - 1; i++)
                {
                    temp2 = arr1[i];
                    if (temp2 == temp)
                        continue;
                    else
                        arr1[i] = arr2[i];
                    arr2[i] = temp2;
                }

            }
            else
            {
                return arr1;
            }
            return arr2;
        }

        public int GetArrayIndexHalf(int[] array1, int userInput)
        {
            int temp = 0;
            if (array1.Length % 2 == 0)
            {
                temp = array1.Length / 2;
                return temp;
            }
            else if (array1.Length % 2 == 1)
            {
                int j = array1.Length - 1;
                j = j / 2;
                temp = j + 1;
            }
            return temp;
        }

        public int[] GetLow2(ref int[] arr1, int indexHalf)
        {
            int temp = 0;
            int[] arr2 = new int[arr1.Length / 2];
            for (int i = 0; i < arr1.Length - indexHalf; i++)
            {
                temp = arr1[i];
                arr1[i] = arr2[i];
                arr2[i] = temp;
                Console.Write($"{arr2[i]},");
            }
            return arr2;
        }

        public int[] GetHigh(ref int[] arr1, int indexHalf)
        {
            int temp = 0;
            int[] arr2 = new int[arr1.Length / 2];
            for (int i = indexHalf + 1; i < arr1.Length + 1; i++)
            {
                arr2[temp] = i;
                Console.Write($"{arr2[temp]},");
                temp++;
            }
            return arr2;
        }
   

    }
}






