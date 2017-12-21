using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
- Визначити клас Car з полями назва, колір, ціна, const полем CompanyName.
- Створити два конструктори – дефолтний і з параметрами.
- Створити властивість доступу до поля колір. 
- Визначити методи:
1) Input() –  для введення даних про машину з консолі
2) Print() - для виведення даних про машину на консоль
3) ChangePrice(double x) – для зміни ціни на х%
- Ввести дані про 3 авто. 
- Зменшити їх ціну на 10%, вивести дані про авто.
- Ввести новий колір і пофарбувати авто з кольором white у вказаний колір
- Перевантажити оператор == для класу Car, авто рівні, якщо назва та ціна рівні 
- Перевизначити в класі Car метод ToString(), який повертає рядок з даними про авто
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
            string myString = "The car's name is " + string.Format(name, this) + ", the color is " + string.Format(color, this) + " and the price is " + string.Format(Convert.ToString(price), this);
            return myString;

        }

        public static bool operator == (Car Car1, Car Car2)
        {
            if (Car1.name == Car2.name && Car1.price == Car2.price)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator != (Car Car1, Car Car2)
        {
            if (!(Car1.name == Car2.name && Car1.price == Car2.price))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Car myFirstCar = new Car("Opel", "Green", 200);
            Car mySecondCar = new Car("Renault", "Black", 400);
            Car myThirdCar = new Car("Mercedes", "White", 1000);
            myFirstCar.ChangePrice(10);
            mySecondCar.ChangePrice(10);
            myThirdCar.ChangePrice(10);
            myThirdCar.Color = "Silver";
        }
    }
}
