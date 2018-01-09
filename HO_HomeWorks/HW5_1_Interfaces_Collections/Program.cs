using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Create interface IDeveloper with property Tool, methods Create() and Destroy()
Create two classes Programmer(with field language) and Builder(with field tool), which implement this interface.
Create List of IDeveloper and add some Programmers and Builders to it.Call Create() and Destroy() methods, property Tool for all of it
*/

namespace HW5_1_Interfaces_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> listOfDevelopers = new List<IDeveloper>();
            listOfDevelopers.Add(new Programmer("C#"));
            listOfDevelopers.Add(new Builder("SpecFlow"));
            foreach (IDeveloper item in listOfDevelopers)
            {
                item.Create();
                item.Destroy();
            }
            listOfDevelopers[0].Tool = "Java8";
            listOfDevelopers[0].Create();
            listOfDevelopers[1].Tool = "VisualStudio";
            listOfDevelopers[1].Create();
        }
    }
}
