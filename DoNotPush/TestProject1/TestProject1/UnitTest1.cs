using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestProject1
{
    public class Tests
    {
        private IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Hello world");
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://google.com");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}