using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Create Console Application project in VS.
In method Main() write code for solving next task:
b) read 3 integers and write max and min of them.
*/

namespace Presentation3_HW1_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter int number one:");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter int number two:");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter int number three:");
            int numberThree = Convert.ToInt32(Console.ReadLine());
            int maxNumber = 0;
            //Max value verification
            if (numberOne > numberTwo && numberOne > numberThree)
                maxNumber = numberOne;
            else
            if (numberTwo > numberOne && numberTwo > numberThree)
                maxNumber = numberTwo;
            else
                if (numberThree > numberOne && numberThree > numberTwo)
                maxNumber = numberThree;
            //Min value verification
            int minNumber = 0;
            if (numberOne < numberTwo && numberOne < numberThree)
                minNumber = numberOne;
            else
            if (numberTwo < numberOne && numberTwo < numberThree)
                minNumber = numberTwo;
            else
                minNumber = numberThree;
            Console.WriteLine("Your max number is {0} and min number is {1}.", maxNumber, minNumber);
            Console.ReadKey();
        }
    }
}
