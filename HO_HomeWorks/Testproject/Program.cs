using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
*/

namespace Testproject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "Hi", "Bye", "Hello", "GoodBye" };
            var items = from s in stringArray
                        where s.EndsWith("e")
                        select s;
            foreach (string myString in items)
            {
                Console.WriteLine(myString);
            }
        }
    }
}