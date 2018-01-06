using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
b) Ask user to enter the number of month. Read the value and write the amount of days in this month
*/

namespace Presentation4_HW_Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a year:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a number of a month:");
            int month = Convert.ToInt32(Console.ReadLine());
            int daysInMonth = DateTime.DaysInMonth(year, month);
            Console.WriteLine("You entered {0}. Month {0} has {1} days.", month, daysInMonth);
            Console.ReadKey();
        }
    }
}
