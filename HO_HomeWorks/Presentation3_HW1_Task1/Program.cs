using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Create Console Application project in VS.
In method Main() write code for solving next task:
a) read 3 float numbers and check: are they all belong to the range [-5,5].
*/

namespace Presentation3_HW1_Task1
{
    class Program
    {
        static void IsnumberInRange(float number)
        {
            bool isNumberInRange = false;
            if (number >= -5 && number <= 5)
                isNumberInRange = true;
            Console.WriteLine("Is your number in range from -5 to 5? - {0}. Your number was {1}.", isNumberInRange, number);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter float number one:");
            float numberOne = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please enter float number two:");
            float numberTwo = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please enter float number three:");
            float numberThree = Convert.ToSingle(Console.ReadLine());
            IsnumberInRange(numberOne);
            IsnumberInRange(numberTwo);
            IsnumberInRange(numberThree);
            Console.ReadKey();
        }
    }
}
