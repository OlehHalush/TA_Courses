using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1. Створити делегат, який отримує і повертає дійсне число.
2. Створити метод Tabulation, який отримує цей делегат та два числа a, b, n  і видруковує значення делегату в точках: a+k* (b-a)/n, k=0,1,2,…n 
3. Викликати метод Tabulation для табуляції функції sin(x), 2x^2+3x* cos(x^3);
*/

namespace Task10
{
    public delegate double MyDelegate(double i);
    class Program
    {
        public static void Tabulation(MyDelegate M, double a, double b, double n)
        {
            double h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(M(a + i * h));
            }
        }
        static void Main(string[] args)
        {
            MyDelegate M = new MyDelegate(Math.Sin);
            Tabulation(M, 1, 2, 3);

            Tabulation(Math.Cos, 1, 2, 3);
        }
    }
}
