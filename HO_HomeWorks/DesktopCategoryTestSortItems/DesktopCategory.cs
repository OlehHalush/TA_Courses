using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DesktopCategorySortItemsTest
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
            // Find and lick "Desktops" button in a top menu
            IWebElement desktopsButton = driver.FindElement(By.XPath("//a[text()='Desktops']"));
            desktopsButton.Click();
            // Find and click "Show All Desktops" button in a top menu
            IWebElement showAllButton = driver.FindElement(By.XPath("//a[text()='Show All Desktops']"));
            showAllButton.Click();
            // Verify that user is on a "Desktops" category page
            IWebElement desktopPageTitle = driver.FindElement(By.XPath("//div[@id='content']/h2[text()='Desktops']"));
            Assert.AreEqual("Desktops", desktopPageTitle.Text);
            // Find and click "Sort" drop down
            IWebElement sortDropdown = driver.FindElement(By.Id("input-sort"));
            sortDropdown.Click();
            // Find and select a value "Name (A - Z)" in a "Sort" drop down
            IWebElement sortDropdownValue = driver.FindElement(By.XPath("//select[@id='input-sort']/option[text()='Name (A - Z)']"));
            sortDropdownValue.Click();
            // Find and verify the actual value in a "Sort" drop down
            IWebElement actualValueInSortDropdown = driver.FindElement(By.XPath("//select[@id='input-sort']/option[@selected='selected']"));
            Assert.AreEqual("Name (A - Z)", actualValueInSortDropdown.Text);
            // Find all items on the page and verify that they are sorted by "Name (A - Z)"
            IList<IWebElement> listOfAllItems = driver.FindElements(By.XPath("//div[@class='row']//div[@class='product-thumb']"));
            // HOW TO VERIFY SORTING??
            driver.Quit();
        }
    }
}
