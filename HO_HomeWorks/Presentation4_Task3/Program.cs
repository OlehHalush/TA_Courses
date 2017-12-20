using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Ввести назву напитку (кава, чай, сік, вода).
Вивести назву напитку і його ціну.
*/

namespace Presentation4_Task3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What would you like to drink? Cofee/Tea/Juice/Water");
            string userInput = Console.ReadLine();
            switch (userInput.ToLower())
            {
                case "cofee":
                    Console.WriteLine("Cofee will cost you 2$.");
                    break;
                case "tea":
                    Console.WriteLine("Tea will cost you 1$.");
                    break;
                case "juice":
                    Console.WriteLine("juice will cost you 2$.");
                    break;
                case "water":
                    Console.WriteLine("Water will cost you 0.5$.");
                    break;
                default:
                    Console.WriteLine("Give me all your money!");
                    break;
            }

            Console.ReadKey();
        }
    }
}