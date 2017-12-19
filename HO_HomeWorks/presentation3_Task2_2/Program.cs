using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Визначити структуру RGB, яка представляє колір з полями red, green, blue типу byte.
Визначити дві змінні цього типу і ввести їх поля для білого та чорного кольорів.
*/

namespace presentation3_Task2_2
{
    struct RGB
    {
        public byte red;
        public byte green;
        public byte blue;
    }

    class Program
    {
        static void Main(string[] args)
        {
            RGB white;
            white.red = 255;
            white.green = 255;
            white.blue = 255;
            RGB black;
            black.red = 0;
            black.green = 0;
            black.blue = 0;
        }
    }
}
