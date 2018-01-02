using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask_Collections
{
    public class TestClass
    {
        public TestClass()
        {
        }

        public TestClass(string myString, char devisionChar)
        {
            this.myString = myString;
            this.devisionChar = devisionChar;
        }

        private string myString;
        private char devisionChar;
        private List<string> myListOfStrings = new List<string>();

        public string MyString
        {
            get
            {
                return this.MyString;
            }
        }

        public char DevisionChar
        {
            get
            {
                return this.devisionChar;
            }
        }

        public List<string> MyListOfStrings
        {
            get
            {
                return this.myListOfStrings;
            }
        }

        public List<string> DevideIntoStringByChar()
        {
            string[] stringArray = this.myString.Split(this.devisionChar);
            foreach (string someString in stringArray)
            {
                this.myListOfStrings.Add(someString);
            }

            return this.myListOfStrings;
        }

        public List<string> DevideIntoStringByChar(string myString, char myChar)
        {
            Console.WriteLine("Here is a list of strings devided by '{0}'.", myChar);
            string[] stringArray = myString.Split(myChar);
            foreach (string someString in stringArray)
            {
                this.myListOfStrings.Add(someString);
            }

            return this.myListOfStrings;
        }

        public void Output()
        {
            foreach (string someString in this.myListOfStrings)
            {
                Console.WriteLine(someString);
            }
        }
    }
}
