using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Define integer variables a and b.
Read values a and b from Console and calculate: a+b, a-b, a*b, a/b.
Output obtained results.
*/

namespace Presentation1_Task1
{
    public class Program
    {
        public static void Addition(int a, int b)
        {
            int resultOfAddition = a + b;
            Console.WriteLine("The result of addition is: {0}", resultOfAddition);
        }

        public static void Subtraction(int a, int b)
        {
            int resultOfSubstruction = a - b;
            Console.WriteLine("The result of subtraction is: {0}", resultOfSubstruction);
        }

        public static void Multiplication(int a, int b)
        {
            int relustOfMultiplication = a * b;
            Console.WriteLine("The result of multiplication is: {0}", relustOfMultiplication);
        }

        public static void Division(int a, int b)
        {
            double convertedAValue = Convert.ToDouble(a);
            double convertedBValue = Convert.ToDouble(b);
            if (convertedBValue == 0)
            {
                throw new ArgumentNullException("Division by 0 is not allowed.");
            }

            double resultOfDivision = convertedAValue / convertedBValue;
            Console.WriteLine("The result of division is: {0}", resultOfDivision);
        }

        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a value 'a', it should be an int:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter a value 'b', it should be an int:");
                int b = Convert.ToInt32(Console.ReadLine());
                Addition(a, b);
                Subtraction(a, b);
                Multiplication(a, b);
                Division(a, b);
                Console.ReadLine();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Divison by 0 is not allowed.");
            }
        }
    }
}
