using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Ввести a  та b – два цілих числа. 
Порахувати скільки цілих чисел  з діапазону [a..b] діляться на 3 без остачі.
*/

namespace Presentation4_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 8;
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