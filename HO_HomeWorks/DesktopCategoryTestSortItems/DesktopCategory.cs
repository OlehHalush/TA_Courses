using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DesktopCategoryTestSortItems
{
    [TestFixture]
    class DesktopCategory
    {
        IWebDriver driver;

        [Test]
        public void SortItems()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://zewer.beget.tech");
            IWebElement desktopsButton = driver.FindElement(By.XPath("//a[text()='Desktops']"));
            desktopsButton.Click();
            IWebElement showAllButton = driver.FindElement(By.XPath("//a[text()='Show All Desktops']"));
            showAllButton.Click();
            IWebElement sortDropdown = driver.FindElement(By.Id("input-sort"));
            sortDropdown.Click();
            IWebElement sortDropdownValue = driver.FindElement(By.XPath("//select[@id='input-sort']/option[text()='Name (A - Z)']"));
            sortDropdownValue.Click();
            IWebElement itemsOnPage = (IWebElement)driver.FindElements(By.XPath("//div[@class='row']/div[@class='product - layout product - grid col - lg - 4 col - md - 4 col - sm - 6 col - xs - 12']"));
        }
    }
}
