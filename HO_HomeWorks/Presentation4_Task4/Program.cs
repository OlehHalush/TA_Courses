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
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 8, 1, 2, 0, -1, 2, 5 };
            int averageValue = 0;
            foreach (int a in intArray)
            {
                if (a < 0)
                {
                    break;
                }
                else
                {
                    averageValue += a;
                }
            }
            Console.WriteLine("The average value is {0}", averageValue);
            Console.ReadKey();
        }
    }
}