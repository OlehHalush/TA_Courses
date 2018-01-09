using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
Write into file ‘DirectoryC.txt’ information(name, type, size) about all directories and files from disc C on your computer.Catch appropriative exceptions.
*/

namespace Task6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dirs = Directory.GetDirectories(@"C:", "*", SearchOption.AllDirectories);
            foreach (string item in dirs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
