using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
14. Написати метод, який для рядка символів обчислює кількість унікальних символів, які входять в цей рядок. Наприклад afggsaa7675afdsg=>8
*/

namespace Task_14
{
    public class Program
    {
        public static void GetAmountOfUniqueCharacters(string userInput)
        {
            int counter = 0;
            var resultString = string.Empty;
            for (int i = 0; i <= userInput.Length - 1; i++)
            {
                if (!resultString.Contains(userInput[i]))
                {
                    resultString += userInput[i];
                    counter += 1;
                }
            }

            Console.WriteLine("There are {0} unique characters in your string.", counter);
            Console.ReadKey();
        }

        public static void Main(string[] args)
        {
            GetAmountOfUniqueCharacters("qqwereeeeee");
            Console.ReadKey();
        }
    }
}
