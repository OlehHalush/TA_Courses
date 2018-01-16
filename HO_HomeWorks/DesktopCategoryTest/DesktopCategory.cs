using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DesktopCategoryTest
{
    [TestFixture]
    class DesktopCategory
    {
        IWebDriver driver;

        [Test]
        public void OpenDesktopPageUsingShowAll()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://zewer.beget.tech");
            IWebElement desktopsButton = driver.FindElement(By.XPath("//a[text()='Desktops']"));
            desktopsButton.Click();
            IWebElement showAllButton = driver.FindElement(By.XPath("//a[text()='Show All Desktops']"));
            showAllButton.Click();
            IWebElement desktopPageTitle = driver.FindElement(By.XPath("//div[@id='content']/h2[text()='Desktops']"));
            Assert.AreEqual("Desktops", desktopPageTitle.Text);
            driver.Quit();
        }

        [Test]
        public void CheckAmountOfItems()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://zewer.beget.tech");
            IWebElement desktopsButton = driver.FindElement(By.XPath("//a[text()='Desktops']"));
            desktopsButton.Click();
            IWebElement showAllButton = driver.FindElement(By.XPath("//a[text()='Show All Desktops']"));
            showAllButton.Click();
            IWebElement leftMenuDesktop = driver.FindElement(By.XPath("//div[@class='list-group']/a[@class='list-group-item active']"));
            int openBracket = leftMenuDesktop.Text.IndexOf("(");
            int closeBracket = leftMenuDesktop.Text.IndexOf(")");
            string actualAmountOfItems = string.Empty;
            for (int i = openBracket + 1; i < closeBracket; i++)
            {
                int e = (int)char.GetNumericValue(leftMenuDesktop.Text[i]);
                actualAmountOfItems += e;
            }
            Assert.AreEqual("13", actualAmountOfItems);
            driver.Quit();
        }
    }
}
