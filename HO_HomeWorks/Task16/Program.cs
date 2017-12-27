using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
16. Написати метод, який отримує масив цілих чисел і повертає індекс N, де сума елементів масиву ліворуч від N дорівнює сумі елементів, що знаходяться праворуч від N. 
Якщо немає такого індексу, поверніть - 1
*/

namespace Task16
{
    public class Program
    {
        public static void GetIndexOfEquality(int[] intArray)
        {
            int leftSideSum = 0;
            int rightSideSum = 0;
            int equalityIndex = -1;
            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                leftSideSum += intArray[i];
                rightSideSum = 0;
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    rightSideSum += intArray[j];
                }

                if (leftSideSum == rightSideSum)
                {
                    equalityIndex = i;
                    break;
                }
            }

            Console.WriteLine("Equality index is {0}.", equalityIndex);
            Console.WriteLine("At index {0} left side sum is {1} and right side sum is {2}", equalityIndex, leftSideSum, rightSideSum);
            Console.ReadKey();
        }

        public static void Main(string[] args)
        {
            int[] someArray = new int[] { 1, 1, 1, 3 };
            GetIndexOfEquality(someArray);
        }
    }
}