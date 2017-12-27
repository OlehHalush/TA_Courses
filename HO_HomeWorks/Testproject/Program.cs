using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
Create method Div(), which calculates the dividing of two  double numbers. 
In Main input  2 double numbers and call this method. Catch appropriative exceptions. 
*/

namespace Testproject
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            string str2;
            using (StreamReader reader = new StreamReader(/*path to the file here*/))
            {
                str1 = reader.ReadLine();
                str2 = reader.ReadLine();
            }
            double num1 = double.Parse(str1);
            double num2 = double.Parse(str2);
            double rez = Div(num1, num2);
            using (StreamWriter stream = new StreamWriter(/*path to a new file*/))
            {
                stream.Write(rez);
            }
        }
    }
}
