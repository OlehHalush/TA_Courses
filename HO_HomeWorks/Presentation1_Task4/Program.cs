using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Enter 2 integer numbers. 
Check if they are both positive – use bool expretion 
*/

namespace Presentation1_Task4
{
    class Program
    {
        static bool IsNumberPositive(int a)
        {
            if (a > 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            bool isFirstNumberPositive = IsNumberPositive(firstNumber);
            bool isSecondNumberPositive = IsNumberPositive(secondNumber);
            Console.WriteLine("Is your first number positive? - {0}.", isFirstNumberPositive);
            Console.WriteLine("Is your second number positive? - {0}.", isSecondNumberPositive);
            Console.ReadKey();
        }
    }
}
