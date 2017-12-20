using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
7) Перевірити чи введене натуральне число містить лише непарні цифри
*/

namespace Presentation4_Task7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string userNumber = Console.ReadLine();
            bool areDigitsPair = false;
            bool isUserInputANumber = int.TryParse(userNumber, out int input);
            if (isUserInputANumber == true)
            {
                foreach (char a in userNumber)
                {
                    double b = char.GetNumericValue(a);
                    if (b % 2 != 0)
                    {
                        areDigitsPair = false;
                        break;
                    }
                    else
                    {
                        areDigitsPair = true;
                    }
                }
            }

            if (areDigitsPair == true)
            {
                Console.WriteLine("All digits is your number are pair.");
            }
            else
            {
                Console.WriteLine("Some digits in your number are odd.");
            }

            Console.ReadKey();
        }
    }
}