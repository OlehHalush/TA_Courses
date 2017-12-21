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
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a double value:");
            double userInput = Convert.ToDouble(Console.ReadLine());
            int firstNumberAfterComa = (int)((userInput % 1) * 10);
            int secondNumberAfterComa = (int)((userInput % 1) * 100) % 10;
            int resultOfAddition = firstNumberAfterComa + secondNumberAfterComa;
            Console.WriteLine(resultOfAddition);
            Console.ReadKey();
        }
    }
}
