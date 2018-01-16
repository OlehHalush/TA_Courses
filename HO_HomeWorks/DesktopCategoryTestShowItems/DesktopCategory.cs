using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DesktopCategoryTestShowItems
{
    [TestFixture]
    public class DesktopCategory
    {
        IWebDriver driver;

        [Test]
        public void Show25Items()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://zewer.beget.tech");
            IWebElement desktopsButton = driver.FindElement(By.XPath("//a[text()='Desktops']"));
            desktopsButton.Click();
            IWebElement showAllButton = driver.FindElement(By.XPath("//a[text()='Show All Desktops']"));
            showAllButton.Click();
            IWebElement showDropdown = driver.FindElement(By.Id("input-limit"));
            showDropdown.Click();
            IWebElement showDropdownValue_25 = driver.FindElement(By.XPath("//select[@id='input-limit']/option[text()='25']"));
            showDropdownValue_25.Click();
            IWebElement actualDropdownValue = driver.FindElement(By.XPath("//select[@id='input-limit']/option[@selected='selected']"));
            string selectedValueText = actualDropdownValue.Text;
            Assert.AreEqual("25", selectedValueText);
        }

    }
}
