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
            driver.Navigate().GoToUrl("http://283-taqc.ml");
            IWebElement desktopsButton = driver.FindElement(By.XPath("//a[text()='Desktops']"));
            desktopsButton.Click();
            IWebElement showAllButton = driver.FindElement(By.XPath("//a[text()='Show All Desktops']"));
            showAllButton.Click();
            IWebElement desktopPageTitle = driver.FindElement(By.XPath("//div[@id='content']/h2[text()='Desktops']"));
            Assert.AreEqual("Desktops", desktopPageTitle.Text);
        }

        [Test]
        public void CheckAmountOfItems()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://283-taqc.ml");
            IWebElement desktopsButton = driver.FindElement(By.XPath("//a[text()='Desktops']"));
            desktopsButton.Click();
            IWebElement showAllButton = driver.FindElement(By.XPath("//a[text()='Show All Desktops']"));
            showAllButton.Click();
            IWebElement leftMenuDesktop = driver.FindElement(By.XPath("//a[@class='list-group-item.active']"));
            int a = leftMenuDesktop.Text.Length;
            string b = leftMenuDesktop.Text;
            int c = Convert.ToInt32(b.Substring(a - 2, a));
            Assert.AreEqual(13, c);
        }
    }
}
