using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Read double number r and calculate the length (l=2*pi*r), area (S=pi*r*r) and volume (4/3*pi*r*r*r) of a circle of given r 
*/

namespace Presenttaion1_HW1_Task3
{
    class Program
    {
        static void GetLengthOfCircle(double a)
        {
            double length = 2 * 3.14 * a;
            Console.WriteLine("The length of a circle is: {0}", length);
        }
        static void GetAreaOfCircle(double a)
        {
            double area = 3.14 * Math.Pow(a, 2);
            Console.WriteLine("The area of a circle is: {0}", area);
        }

        static void GetVolumeOfCircle(double a)
        {
            double volume = 4 / 3 * 3.14 * Math.Pow(a, 3);
            Console.WriteLine("The volume of a circle is: {0}", volume);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a double number:");
            double doubleNumber = Convert.ToInt32(Console.ReadLine());
            GetLengthOfCircle(doubleNumber);
            GetAreaOfCircle(doubleNumber);
            GetVolumeOfCircle(doubleNumber);
            Console.ReadKey();
        }
    }
}
