using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Create Console Application project in VS.
In the Main() method declare Dictionary<uint, string>.
Add to Dictionary from Console seven pairs(ID, Name) of some persons.
Ask user to enter ID, then find and write corresponding Name from your Dictionary.
If you can't find this ID - say about it to user. 
*/

namespace HW5_2_Interfaces_Collections
{
    public class Program
    {
        public static void GetValue(uint key, Dictionary<uint, string> someDictionary)
        {
            foreach (KeyValuePair<uint, string> someValues in someDictionary)
            {
                if (someValues.Key == key)
                {
                    Console.WriteLine("The ID is {0} and the Name is {1}.", someValues.Key, someValues.Value);
                }
            }
        }

        public static void Main(string[] args)
        {
            Dictionary<uint, string> myDictionary = new Dictionary<uint, string>();
            myDictionary.Add(1, "Oleg");
            myDictionary.Add(2, "Roman");
            myDictionary.Add(3, "Andriy");
            GetValue(3, myDictionary);
        }
    }
}
