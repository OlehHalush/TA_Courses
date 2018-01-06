using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Визначити структуру RGB, яка представляє колір з полями red, green, blue типу byte.
Визначити дві змінні цього типу і ввести їх поля для білого та чорного кольорів.
*/

namespace Presentation3_Task2_2
{
    public struct RGB
    {
        public byte Red;
        public byte Green;
        public byte Blue;
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            RGB white;
            white.Red = 255;
            white.Green = 255;
            white.Blue = 255;
            RGB black;
            black.Red = 0;
            black.Green = 0;
            black.Blue = 0;
        }
    }
}
