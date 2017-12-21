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
    public class Program
    {
        public static void Main(string[] args)
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
