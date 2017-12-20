using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
c) Enter 10 integer numbers. Calculate the sum of first 5 elements if they are positive or product of last 5 element in  the other case.
*/

namespace Presentation4_HW_Task3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int result = 0;
            int[] intArray = new int[10] { 1, 0, 7, 8, 1, 4, 7, 10, 2, 3 };
            for (int i = 0; i <= 4; i++)
            {
                if (intArray[i] > 0)
                {
                    result += intArray[i];
                }
                else
                {
                    for (int j = 5; j <= 9; j++)
                    {
                        result *= intArray[j];
                    }
                }
            }

            Console.WriteLine("The result is {0}.", result);
            Console.ReadKey();
        }
    }
}
