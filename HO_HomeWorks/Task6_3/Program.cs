using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.AccessControl;

/*
Write into file ‘DirectoryC.txt’ information(name, type, size) about all directories and files from disc C on your computer.Catch appropriative exceptions. 
*/
//=====================================================NOT DONE=========================================================

namespace Task6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Directory.GetAccessControl(@"C:\Documents and Settings");
                string[] dirs = Directory.GetDirectories(@"C:", "*", SearchOption.AllDirectories);
                foreach (string item in dirs)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
