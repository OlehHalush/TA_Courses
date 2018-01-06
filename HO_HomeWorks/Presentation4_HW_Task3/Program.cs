using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
c) Enter 10 integer numbers. Calculate the sum of first 5 elements if they are positive or product of last 5 element in the other case.
*/

namespace Presentation4_HW_Task3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int result = 0;
            bool isNegative = false;
            int[] intArray = new int[10] { 1, 1, 1, 1, -8, -1, 1, 2, 2, 2 };
            for (int i = 0; i < 5; i++)
            {
                if (intArray[i] < 0)
                {
                    isNegative = true;
                    result = 1;
                }
            }

            if (isNegative == false)
            {
                for (int i = 0; i < 5; i++)
                {
                    result += intArray[i];
                }
            }
            else
            {
                result = 1;
                for (int i = 5; i < 10; i++)
                {
                    result *= intArray[i];
                }
            }

            Console.WriteLine("The result is {0}.", result);
            Console.ReadKey();
        }
    }
}
