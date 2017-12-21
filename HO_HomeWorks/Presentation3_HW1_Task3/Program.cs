using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Create Console Application project in VS.
In method Main() write code for solving next task:
c) read number of HTTP Error (400, 401,402, ...) and write the name of this error (Declare enum HTTPError)
*/

namespace Presentation3_HW1_Task3
{
    public enum HTTPError
    {
        BadRequest,
        Unauthorized,
        PaymentRequired,
        Forbidden,
        NotFound,
        GoogleWillHelpYou
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number of your error:");
            int errorNumber = Convert.ToInt32(Console.ReadLine());
            HTTPError error;
            switch (errorNumber)
            {
                case 400:
                    error = HTTPError.BadRequest;
                    break;
                case 401:
                    error = HTTPError.Unauthorized;
                    break;
                case 402:
                    error = HTTPError.PaymentRequired;
                    break;
                case 403:
                    error = HTTPError.Forbidden;
                    break;
                case 404:
                    error = HTTPError.NotFound;
                    break;
                default:
                    error = HTTPError.GoogleWillHelpYou;
                    break;
            }

            Console.WriteLine(error);
            Console.ReadKey();
        }
    }
}
