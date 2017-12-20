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
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            double sum = 0;
            string userNumber = Console.ReadLine();
            bool isUserInputANumber = int.TryParse(userNumber, out int input);
            if (isUserInputANumber == true)
            {
                for (int i = 0; i <= userNumber.Length - 1; i++)
                {
                    sum += char.GetNumericValue(userNumber[i]);
                }
            }

            Console.WriteLine("The sum of numbers is {0}", sum);
            Console.ReadKey();
        }
    }
}