using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
5) Перевірити чи введений рік є високосним
*/

namespace Presentation4_Task5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a year:");
            int year = Convert.ToInt32(Console.ReadLine());
            bool isYearALeapYear = false;
            if (isYearALeapYear = DateTime.IsLeapYear(year))
            {
                Console.WriteLine("You entered {0} year. It's a leap year.", year);
            }
            else
            {
                Console.WriteLine("You entered {0} year. It's not a leap year.", year);
            }

            Console.ReadKey();
        }
    }
}