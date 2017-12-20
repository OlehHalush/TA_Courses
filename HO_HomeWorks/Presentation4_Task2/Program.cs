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
    class Program
    {
        static void Main(string[] args)
        {
            string str = "myName";
            for (int i = 0; i < str.Length; i += 2)
            {
                Console.Write(str[i]);
            }
            Console.ReadKey();
        }
    }
}