using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
6) Знайти суму цифр введеного цілого числа
*/

namespace Presentation4_Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int sum = 0;
            string userNumber = Console.ReadLine();
            bool isUserInputANumber = Int32.TryParse(userNumber, out int input);
            if (isUserInputANumber == true)
            {
                for (int i = 0; i <= input; i++)
                {
                    sum += i;
                }
            }
            Console.WriteLine("The sum of numbers is {0}", sum);
            Console.ReadKey();
        }
    }
}