using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Створити делегат void MyDel(int m) 
Створити клас Student, з полями name та marks (типу list<int>), подією MarkChange типу MyDel та методом AddMark (додає нову оцінку до marks, перевіряє чи хтось підписався на подію і викликає її з новою оцінкою)
Створити клас Parent  з методом OnMarkChange (який отримує int оцінку і виводить її на консоль)
В Main Створити студента, батька, підписати батьківський метод OnMarkChange на подію студента MarkChange. Викликати кілька разів метод AddMark для студента 
Створити клас Бухгалтерія, метод ВиплатаСтипендії, який друкує чи буде в студента стипендія чи ні, залежно від свого параметра. Підписати цей метод на подію студента MarkChange
*/

namespace Task10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student();
            Parent dad1 = new Parent();
            stud1.MarksChanged += dad1.OnMarkChange;
            stud1.AddMark(5);
            stud1.AddMark(4);
            Parent mam = new Parent();
            stud1.MarksChanged += mam.OnMarkChange;
            stud1.AddMark(2);
        }
    }
}
