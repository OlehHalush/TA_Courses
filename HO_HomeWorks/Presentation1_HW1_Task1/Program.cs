using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Create Console Application project in VS.
In method Main() write code for solving next tasks:
b) define integer variable a. Read the value of a from console and calculate area and perimeter of square with length a. 
Output obtained results.
*/

namespace Presentation1_HW1_Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int squareArea = Convert.ToInt32(Math.Pow(a, 2));
            int squarePerimeter = 4 * a;
            Console.WriteLine("An area of a square is: {0}", squareArea);
            Console.WriteLine("A perimeter of a square is: {0}", squarePerimeter);
            Console.ReadLine();
        }
    }
}
