using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
a) Read the text as a string value and calculate the counts of characters 'a', 'o', 'i', 'e' in this text.
*/

namespace Presentation4_HW_Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter some string:");
            string userInput = Console.ReadLine();
            int counterA = 0;
            int counterO = 0;
            int counterI = 0;
            int counterE = 0;
            foreach (char a in userInput)
            {
                switch (char.ToString(a).ToLower())
                {
                    case "a":
                        counterA += 1;
                        continue;
                    case "o":
                        counterO += 1;
                        continue;
                    case "i":
                        counterI += 1;
                        continue;
                    case "e":
                        counterE += 1;
                        continue;
                }
            }

            Console.WriteLine("Counter 'a' is {0}.", counterA);
            Console.WriteLine("Counter 'o' is {0}.", counterO);
            Console.WriteLine("Counter 'i' is {0}.", counterI);
            Console.WriteLine("Counter 'e' is {0}.", counterE);
            Console.ReadKey();
        }
    }
}
