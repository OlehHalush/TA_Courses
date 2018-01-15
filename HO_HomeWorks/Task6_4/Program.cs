using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
Select from directory D only .txt files and print the text from it into console. Catch appropriative exceptions.
*/
//=====================================================NOT DONE=========================================================

namespace Task6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dirs = Directory.GetDirectories(@"D:");
            foreach (string item in dirs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
