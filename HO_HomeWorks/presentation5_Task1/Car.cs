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
            this.name = someName;
            this.color = someColor;
            this.price = somePrice;
        }

        private string name;
        private string color;
        private double price;
        private const string CompanyName = "GiveMeAllTheMoNey";

        public string Color
        {
            get
            {
                return this.color;
            }

            set
            {
                this.color = value;
            }
        }

        public void Input()
        {
            Console.WriteLine("Please enter name of your car:");
            this.name = Console.ReadLine();
            Console.WriteLine("Please enter a color of your car:");
            this.color = Console.ReadLine();
            Console.WriteLine("Please enter a price of your car:");
            this.price = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

        public double ChangePriceUp(double price)
        {
            this.price = UpOnPersentage(price, this.price);
            return this.price;
        }

        public double ChangePriceDown(double price)
        {
            this.price = DownOnPersentage(price, this.price);
            return this.price;
        }

        public static double UpOnPersentage(double pers, double total)
        {
            double persent = total + ((pers / 100) * total);
            return persent;
        }

        public static double DownOnPersentage(double pers, double total)
        {
            double persent = total - ((pers / 100) * total);
            return persent;
        }

        public override string ToString()
        {
            string myString = "The car's name is " + string.Format(this.name, this) + ", the color is " + string.Format(this.color, this) + " and the price is " + string.Format(Convert.ToString(this.price), this);
            return myString;
        }

        public static bool operator ==(Car car1, Car car2)
        {
            if (car1.name == car2.name && car1.price == car2.price)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Car car1, Car car2)
        {
            if (!(car1.name == car2.name && car1.price == car2.price))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
