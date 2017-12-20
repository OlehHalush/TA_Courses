using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Ввести a та b – два цілих числа. 
Порахувати скільки цілих чисел  з діапазону [a..b] діляться на 3 без остачі.
*/

namespace Presentation4_Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; a <= b; a++)
            {
                if (a % 3 == 0)
                {
                    Console.WriteLine(a);
                }
            }

            Console.ReadLine();
        }
    }
}