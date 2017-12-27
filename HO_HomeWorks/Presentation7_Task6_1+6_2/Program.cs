using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
1) Create method Div(), which calculates the dividing of two  double numbers. 
In Main input  2 double numbers and call this method. Catch appropriative exceptions. 
2) Read and write all data in task1 from data.txt into rez.txt files, by using (Catch appropriative exceptions):
StreamReader StreamWriter
File.WriteAllText
*/

namespace Presentation7_Task6_1_6_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyClass myProgram = new MyClass();
            try
            {
                myProgram.ReadFromFile();
                myProgram.Divide();
                myProgram.OutputIntoFile();
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
