using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace TestingLibrary
{
    [TestFixture]
    class Class2
    {
        IWebDriver driver;
        [SetUp]
        public void init()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void test1()
        {
            driver.Navigate().GoToUrl("http://localhost:3059/");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).Clear();
            driver.FindElement(By.Id("gender")).SendKeys("Female");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).Clear();
            driver.FindElement(By.Id("age")).SendKeys("20");
            driver.FindElement(By.XPath("//input[@value='Calculate!']")).Click();
        }
        [Test]
        public void test2()
        {
            driver.Navigate().GoToUrl("http://localhost:3059/");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).Clear();
            driver.FindElement(By.Id("gender")).SendKeys("male");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).Clear();
            driver.FindElement(By.Id("age")).SendKeys("20");
            driver.FindElement(By.XPath("//input[@value='Calculate!']")).Click();
        }
        public void test3()
        {
            driver.Navigate().GoToUrl("http://localhost:3059/");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).Clear();
            driver.FindElement(By.Id("gender")).SendKeys("female");
            driver.FindElement(By.XPath("//form[@action='/Home/Form']")).Click();
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).Clear();
            driver.FindElement(By.Id("age")).SendKeys("32");
            driver.FindElement(By.XPath("//input[@value='Calculate!']")).Click();
        }
        [Test]
        public void test4()
        {
            driver.Navigate().GoToUrl("http://localhost:3059/");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).Clear();
            driver.FindElement(By.Id("gender")).SendKeys("male");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).Clear();
            driver.FindElement(By.Id("age")).SendKeys("32");
            driver.FindElement(By.XPath("//input[@value='Calculate!']")).Click();
        }
        [Test]
        public void test5()
        {
            driver.Navigate().GoToUrl("http://localhost:3059/");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).Clear();
            driver.FindElement(By.Id("gender")).SendKeys("male");
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).Clear();
            driver.FindElement(By.Id("age")).SendKeys("52");
            driver.FindElement(By.XPath("//input[@value='Calculate!']")).Click();
        }
        [TearDown]
        public void Close()
        {
            driver.Close();
        }

    }
}
