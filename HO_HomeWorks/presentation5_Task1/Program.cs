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

namespace Presentation5_Task1
{
    public class Car
    {
        public Car()
        {
        }

        public Car(string someName, string someColor, double somePrice)
        {
            name = someName;
            color = someColor;
            price = somePrice;
        }

        private string name;
        private string color;

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        private double price;
        const string CompanyName = "GiveMeAllTheMoNey";
        

        public void Input()
        {
            Console.WriteLine("Please enter name of your car:");
            name = Console.ReadLine();
            Console.WriteLine("Please enter a color of your car:");
            color = Console.ReadLine();
            Console.WriteLine("Please enter a price of your car:");
            price = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine("The car's name is {0}, color is {1} and the price is {2}", name, color, price);
        }

        public double ChangePrice(double x)
        {
            price = ToPersentage(x, price);
            return price;
        }

        public static double ToPersentage(double percent, double total)
        {
            double pers = total + ((percent / 100) * total);
            return pers;
        }

        public override string ToString()
        {
            string myString = "The car's name is " + string.Format(name, this) + " ,the color is " + string.Format(color, this) + " and the price is " + string.Format(Convert.ToString(price), this);
            return myString;

        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Car myFirstCar = new Car("Opel", "Green", 200);
            Car mySecondCar = new Car("Renault", "Black", 400);
            Car myThirdCar = new Car("Mercedes", "White", 1000);
            Console.WriteLine(myFirstCar.ToString());
            Console.ReadKey();
        }
    }
}
