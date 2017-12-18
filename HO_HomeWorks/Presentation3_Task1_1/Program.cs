using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Ввести два цілих числа day та month і перевірити чи можуть вони представляти день та місяць.
Вивести true чи false
*/

namespace Presentation3_Task1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number:");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter socond number:");
            int month = Convert.ToInt32(Console.ReadLine());
            bool canBeADay = false;
            bool canBeAMonth = false;
            if (day > 0 && day < 32)
                canBeADay = true;
            if (month > 0 && month < 13)
                canBeAMonth = true;
            Console.WriteLine("Can your first number be a day? - {0}", canBeADay);
            Console.WriteLine("Can your second number be a month? - {0}", canBeAMonth);
            Console.ReadKey();
        }
    }
}
