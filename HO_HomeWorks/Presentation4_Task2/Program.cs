using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Ввести рядок символів. Видрукувати кожен другий символ 
*/

namespace Presentation4_Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = "myNameisOleg";
            for (int i = 1; i < str.Length; i += 2)
            {
                Console.Write(str[i]);
            }

            Console.ReadKey();
        }
    }
}