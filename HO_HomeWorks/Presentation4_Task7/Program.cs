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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string userNumber = Console.ReadLine();
            bool isUserInputANumber = Int32.TryParse(userNumber, out int input);
            if (isUserInputANumber == true)
            {
                foreach (char a in userNumber)
                {
                    double b = char.GetNumericValue(a);
                    if (b % 2 != 0)
                    {
                        Console.WriteLine("Some chars in your number are odd.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("All chars is your number are pair.");
                    }
                }
                Console.ReadKey();
            }
        }
    }
}