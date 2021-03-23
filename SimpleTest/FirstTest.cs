using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace SimpleTest
{
    class FirstTest
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new FirefoxDriver();

            driver.Manage().Window.Maximize();
        }

        [Test]
        public void test()
        {
            driver.Url = "https://www.wikipedia.org/";
            IWebElement searchField = driver.FindElement(By.XPath("//input[@id=\"searchInput\"]"));

            searchField.SendKeys("automation testing");
            IWebElement searchButton = driver.FindElement(By.XPath("//*[@id=\"search-form\"]/fieldset/button"));
            searchButton.Click();
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
