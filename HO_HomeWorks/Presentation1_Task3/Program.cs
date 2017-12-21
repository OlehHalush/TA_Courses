using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Read 3 variables of char type. 
Write message: “You enter (first char), (second char), (3 char)”
*/

namespace Presentation1_Task3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first char:");
            char firstChar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter second char:");
            char secondChar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter third char:");
            char thirdChar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Your first char is: {0}", firstChar);
            Console.WriteLine("Your second char is: {0}", secondChar);
            Console.WriteLine("Your third char is: {0}", thirdChar);
            Console.ReadKey();
        }
    }
}
