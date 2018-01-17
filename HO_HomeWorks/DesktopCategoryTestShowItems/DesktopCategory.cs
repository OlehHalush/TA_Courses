using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DesktopCategoryShowItemsTest
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
            // Find and click "Desktops" button in a top menu
            IWebElement desktopsButton = driver.FindElement(By.XPath("//a[text()='Desktops']"));
            desktopsButton.Click();
            // Find and click "Show All Desktops" button in a top menu
            IWebElement showAllButton = driver.FindElement(By.XPath("//a[text()='Show All Desktops']"));
            showAllButton.Click();
            // Find and click "Show" drop down
            IWebElement showDropdown = driver.FindElement(By.Id("input-limit"));
            showDropdown.Click();
            // Find and select a value "25" in a "Show" drop down
            IWebElement showDropdownValue_25 = driver.FindElement(By.XPath("//select[@id='input-limit']/option[text()='25']"));
            showDropdownValue_25.Click();
            // Find the actual value in a "Show" drop down and verify that it is "25"
            IWebElement actualDropdownValue = driver.FindElement(By.XPath("//select[@id='input-limit']/option[@selected='selected']"));
            string selectedValueText = actualDropdownValue.Text;
            Assert.AreEqual("25", selectedValueText);
            // Find all the items on the page and verify that their amount is sell than "25"
            IList<IWebElement> listOfAllItems = driver.FindElements(By.XPath("//div[@class='row']//div[@class='product-thumb']"));
            int i = listOfAllItems.Count();
            Assert.That(i <= 25);
            driver.Quit();
        }

    }
}
