using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Presentation7_Task6_1_6_2
{
    public class MyClass
    {
        public MyClass()
        {
        }

        public MyClass(string pathToRead, string pathToWrite)
        {
            this.pathToRead = @pathToRead;
            this.pathToWrite = @pathToWrite;
        }

        private string pathToRead = @"C:\data.txt";
        private string pathToWrite = @"C:\rez.txt";
        private double number1;
        private double number2;
        private double result;

        public double Result
        {
            get
            {
                return this.result;
            }
        }

        public void ReadFromFile()
        {
            string userInput1;
            string userInput2;
            using (StreamReader reader = new StreamReader(@pathToRead))
            {
                userInput1 = reader.ReadLine();
                userInput2 = reader.ReadLine();
            }

            this.number1 = double.Parse(userInput1);
            this.number2 = double.Parse(userInput2);
        }

        public void Divide()
        {
            if (this.number1 == 0)
            {
                throw new ArgumentNullException("Dividing 0 always results in 0.");
            }

            if (this.number2 == 0)
            {
                throw new ArgumentNullException("Division by 0 is not allowed.");
            }

            this.result = this.number1 / this.number2;
            Console.WriteLine("The result of division {0} by {1} is {2}", this.number1, this.number2, this.Result);
        }

        public void OutputIntoFile()
        {
            using (StreamWriter writer = new StreamWriter(@pathToWrite))
            {
                writer.WriteLine("Number one is: {0}.", this.number1);
                writer.WriteLine("Number two is: {0}", this.number2);
                writer.WriteLine("The result of division is: {0}.", this.Result);
            }
        }
    }
}
