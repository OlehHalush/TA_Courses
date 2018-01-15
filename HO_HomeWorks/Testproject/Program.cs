using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

/*
*/

namespace Testproject
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://283-taqc.ml/upload/");
            IWebElement search = driver.FindElement(By.Name("search"));
            search.SendKeys("Mac");
        }
    }
}