using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_SeleniumLabTask
{
    class ITest
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void test()
        {
            driver.Url = "https://asteriabd.com/";
            IWebElement element = driver.FindElement(By.Name("username"));
            element.SendKeys("mayshaafrin@iut-dhaka.edu");
            IWebElement password = driver.FindElement(By.Name("password"));
            password.SendKeys("xGztKww7M3Yfyuh");
            driver.FindElement(By.Id("LOG IN")).Click();
            String at = driver.Title;

            String et = "Shop Shajgoj";
            if (at == et)
            {
                Console.WriteLine("Test Successful");
                IWebElement element2 =
                driver.FindElement(By.XPath("/html/body/table/tbody/tr[4]/td/div/div/div[2]/a"));
                element2.Click();
            }
            else
            {
                Console.WriteLine("Unsuccessful");
            }
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
