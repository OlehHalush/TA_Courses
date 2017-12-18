using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Ввести дійсне число  number і отримати 2 перші цифри після коми цього числа.
Вивести суму цих цифр. Напр.: 3.456->4+5=9
*/

namespace Presentation3_Task1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter double value:");
            double userInput = Convert.ToDouble(Console.ReadLine());
            userInput /= 1;
            string userNumber = Convert.ToString(userInput);
            char[] charArray = new char[2];
            char first = userNumber[2];
            char second = userNumber[3];
            int firstNumber = Convert.ToInt32(first);
            int secondNumber = Convert.ToInt32(second);
            int result = first + second;
            Console.WriteLine(first);
            Console.ReadKey();
        }
    }
}
