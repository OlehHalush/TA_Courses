using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DesktopCategoryAmountOfItemsTest
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
            // Find and click "Desktops" button in a top menu
            IWebElement desktopsButton = driver.FindElement(By.XPath("//a[text()='Desktops']"));
            desktopsButton.Click();
            // Find and click "Show All Desktops" button in a top menu
            IWebElement showAllButton = driver.FindElement(By.XPath("//a[text()='Show All Desktops']"));
            showAllButton.Click();
            // Verify that user is on a "Desktops" category page
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
            // Find and click "Desktops" button in a top menu
            IWebElement desktopsButton = driver.FindElement(By.XPath("//a[text()='Desktops']"));
            desktopsButton.Click();
            // Find and click "Show All Desktops" button in a top menu
            IWebElement showAllButton = driver.FindElement(By.XPath("//a[text()='Show All Desktops']"));
            showAllButton.Click();
            // Verify that user is on a "Desktops" category page
            IWebElement desktopPageTitle = driver.FindElement(By.XPath("//div[@id='content']/h2[text()='Desktops']"));
            Assert.AreEqual("Desktops", desktopPageTitle.Text);
            // Get the amount of items in a "Desktops" category in a left side menu 
            IWebElement leftMenuDesktop = driver.FindElement(By.XPath("//div[@class='list-group']/a[@class='list-group-item active']"));
            int openBracket = leftMenuDesktop.Text.IndexOf("(");
            int closeBracket = leftMenuDesktop.Text.IndexOf(")");
            string actualAmountOfItems = string.Empty;
            for (int i = openBracket + 1; i < closeBracket; i++)
            {
                int digit = (int)char.GetNumericValue(leftMenuDesktop.Text[i]);
                actualAmountOfItems += digit;
            }
            Assert.AreEqual("13", actualAmountOfItems);
            driver.Quit();
        }
    }
}
