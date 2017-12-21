using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Визначити клас Car з полями назва, колір, ціна, const полем CompanyName.
Створити два конструктори – дефолтний і з параметрами.
Створити властивість доступу до поля колір. 
Визначити методи Input() –  для введення даних про машину з консолі,                               
Print() - для виведення даних про машину на консоль                              
ChangePrice(double x) – для зміни ціни на х%
*/

namespace presentation5_Task1
{
    public class Car
    {
        protected string name;
        private string color;
        public string Color
        {
            get
            {
                return name;   
            }
            set
            {
                name = value;
            }
        }

        protected double price;
        const string CompanyName = "GiveMeAllTheMoNey";
        Car()
        { }
        Car(string someName, string someColor, double somePrice)
        {
            name = someName;
            Color = someColor;
            price = somePrice;
        }

        protected void InsertData(string someName, string someColor, double somePrice)
        { 
             name = someName;
             Color = someColor;
             price = somePrice;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
