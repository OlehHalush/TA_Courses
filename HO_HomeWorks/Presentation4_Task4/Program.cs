using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Введіть послідовність додатніх цілих чисел (до першого від’ємного). 
Обчисліть середнє арифметичне значення введених чисел.
*/

namespace Presentation4_Task4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] intArray = new int[] { 30, 3, -1, 2, 5 };
            double arithmeticMean = 0;
            double sum = 0;
            double count = 0;
            foreach (int a in intArray)
            {
                if (a < 0)
                {
                    break;
                }
                else
                {
                    sum += a;
                    count += 1;
                }
            }

            arithmeticMean = sum / count;
            Console.WriteLine("The arithmetic mean value is {0}", arithmeticMean);
            Console.ReadKey();
        }
    }
}