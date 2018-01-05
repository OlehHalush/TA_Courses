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
            Student student = new Student();
            Parent daddy = new Parent();
            Parent mommy = new Parent();
            AccountingDepartment accounter = new AccountingDepartment();
            student.MarksChanged += daddy.SendSMS;
            student.MarksChanged += mommy.SendSMS;
            student.MarksChanged += accounter.PayScholarship;
            student.AddMark(2);
            student.AddMark(3);
        }
    }
}
